﻿using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Objects.BuiltElements.Revit;
using Objects.Geometry;
using Speckle.Core.Models;

using DB = Autodesk.Revit.DB;
using Point = Objects.Geometry.Point;

namespace Objects.Converter.Revit
{
  public partial class ConverterRevit
  {
    public ApplicationPlaceholderObject OpeningToNative(BuiltElements.Opening speckleOpening)
    {
      var baseCurves = CurveToNative(speckleOpening.outline);

      var docObj = GetExistingElementByApplicationId(speckleOpening.applicationId);
      if (docObj != null)
      {
        Doc.Delete(docObj.Id);
      }

      DB.Opening revitOpening = null;

      switch (speckleOpening)
      {
        case RevitWallOpening rwo:
          {
            if (CurrentHostElement as Wall == null)
              throw new Speckle.Core.Logging.SpeckleException($"Hosted wall openings require a host wall");
            var points = (rwo.outline as Polyline).points.Select(x => PointToNative(x)).ToList();
            revitOpening = Doc.Create.NewOpening(CurrentHostElement as Wall, points[0], points[2]);
            break;
          }

        case RevitVerticalOpening rvo:
          {
            if (CurrentHostElement == null)
              throw new Speckle.Core.Logging.SpeckleException($"Hosted vertical openings require a host family");
            revitOpening = Doc.Create.NewOpening(CurrentHostElement, baseCurves, true);
            break;
          }

        case RevitShaft rs:
          {
            var bottomLevel = LevelToNative(rs.bottomLevel);
            var topLevel = LevelToNative(rs.topLevel);
            revitOpening = Doc.Create.NewOpening(bottomLevel, topLevel, baseCurves);
            TrySetParam(revitOpening, BuiltInParameter.WALL_USER_HEIGHT_PARAM, rs.height, rs.units);

            break;
          }

        default:
          if (CurrentHostElement as Wall != null)
          {
            var points = (speckleOpening.outline as Polyline).points.Select(x => PointToNative(x)).ToList();
            revitOpening = Doc.Create.NewOpening(CurrentHostElement as Wall, points[0], points[2]);
          }
          else
          {
            ConversionErrors.Add(new Exception("Cannot create Opening, opening type not supported"));
            throw new Speckle.Core.Logging.SpeckleException("Opening type not supported");
          }
          break;
      }

      if (speckleOpening is RevitOpening ro)
      {
        SetInstanceParameters(revitOpening, ro);
      }

      return new ApplicationPlaceholderObject { NativeObject = revitOpening, applicationId = speckleOpening.applicationId, ApplicationGeneratedId = revitOpening.UniqueId };
    }

    public BuiltElements.Opening OpeningToSpeckle(DB.Opening revitOpening)
    {
      if (!ShouldConvertHostedElement(revitOpening, revitOpening.Host))
        return null;

      RevitOpening speckleOpening;
      if (revitOpening.IsRectBoundary)
      {
        speckleOpening = new RevitWallOpening();

        var poly = new Polyline();
        poly.value = new List<double>();

        //2 points: bottom left and top right
        var btmLeft = PointToSpeckle(revitOpening.BoundaryRect[0]);
        var topRight = PointToSpeckle(revitOpening.BoundaryRect[1]);
        poly.value.AddRange(btmLeft.ToList());
        poly.value.AddRange(new Point(btmLeft.x, btmLeft.y, topRight.z, ModelUnits).ToList());
        poly.value.AddRange(topRight.ToList());
        poly.value.AddRange(new Point(topRight.x, topRight.y, btmLeft.z, ModelUnits).ToList());
        poly.value.AddRange(btmLeft.ToList());
        poly.units = ModelUnits;
        speckleOpening.outline = poly;
      }
      else
      {
        if (revitOpening.Host != null)
        {
          //we can ignore vertical openings because they will be created when we try re-create voids in the roof / ceiling / floor outline
          return null;
          //speckleOpening = new RevitVerticalOpening();
        }
        else
        {
          speckleOpening = new RevitShaft();
          if (revitOpening.get_Parameter(BuiltInParameter.WALL_HEIGHT_TYPE) != null)
          {
            ((RevitShaft)speckleOpening).topLevel = ConvertAndCacheLevel(revitOpening, BuiltInParameter.WALL_HEIGHT_TYPE);
            ((RevitShaft)speckleOpening).bottomLevel = ConvertAndCacheLevel(revitOpening, BuiltInParameter.WALL_BASE_CONSTRAINT);
            ((RevitShaft)speckleOpening).height = GetParamValue<double>(revitOpening, BuiltInParameter.WALL_USER_HEIGHT_PARAM);
          }
        }

        var poly = new Polycurve(ModelUnits);
        poly.segments = new List<ICurve>();
        foreach (DB.Curve curve in revitOpening.BoundaryCurves)
        {
          if (curve != null)
          {
            poly.segments.Add(CurveToSpeckle(curve));
          }
        }
        speckleOpening.outline = poly;
      }

      speckleOpening["type"] = revitOpening.Name;

      GetAllRevitParamsAndIds(speckleOpening, revitOpening, new List<string> { "WALL_BASE_CONSTRAINT", "WALL_HEIGHT_TYPE", "WALL_USER_HEIGHT_PARAM" });

      return speckleOpening;
    }
  }
}
