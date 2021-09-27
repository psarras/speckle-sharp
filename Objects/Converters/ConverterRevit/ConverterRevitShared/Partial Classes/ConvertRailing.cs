﻿using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Objects.BuiltElements.Revit;
using Objects.Geometry;
using Speckle.Core.Models;

namespace Objects.Converter.Revit
{
  public partial class ConverterRevit
  {
    public List<ApplicationPlaceholderObject> RailingToNative(BuiltElements.Revit.RevitRailing speckleRailing)
    {
      if (speckleRailing.path == null)
      {
        throw new Speckle.Core.Logging.SpeckleException("Only line based Railings are currently supported.");
      }

      var revitRailing = GetExistingElementByApplicationId(speckleRailing.applicationId) as Railing;

      var railingType = GetElementType<RailingType>(speckleRailing);
      Level level = LevelToNative(speckleRailing.level);

      //we currently don't support railings hosted on stairs, and these have null level
      if (level == null)
        return null;
      var baseCurve = CurveArrayToCurveLoop(CurveToNative(speckleRailing.path));

      //if it's a new element, we don't need to update certain properties
      bool isUpdate = true;
      if (revitRailing == null)
      {
        isUpdate = false;
        revitRailing = Railing.Create(Doc, baseCurve, railingType.Id, level.Id);
      }
      if (revitRailing == null)
      {
        ConversionErrors.Add(new Exception($"Failed to create railing ${speckleRailing.applicationId}."));
        return null;
      }

      if (revitRailing.GetTypeId() != railingType.Id)
      {
        revitRailing.ChangeTypeId(railingType.Id);
      }

      if (isUpdate)
      {
        revitRailing.SetPath(baseCurve);
        TrySetParam(revitRailing, BuiltInParameter.WALL_BASE_CONSTRAINT, level);
      }

      if (speckleRailing.flipped != revitRailing.Flipped)
      {
        revitRailing.Flip();
      }

      SetInstanceParameters(revitRailing, speckleRailing);

      var placeholders = new List<ApplicationPlaceholderObject>()
      {
        new ApplicationPlaceholderObject
        {
        applicationId = speckleRailing.applicationId,
        ApplicationGeneratedId = revitRailing.UniqueId,
        NativeObject = revitRailing
        }
      };

      Doc.Regenerate();

      return placeholders;
    }

    //TODO: host railings, where possible
    private RevitRailing RailingToSpeckle(Railing revitRailing)
    {

      var railingType = Doc.GetElement(revitRailing.GetTypeId()) as RailingType;
      var speckleRailing = new RevitRailing();
      //speckleRailing.family = railingType.FamilyName;
      speckleRailing.type = railingType.Name;
      speckleRailing.level = ConvertAndCacheLevel(revitRailing, BuiltInParameter.STAIRS_RAILING_BASE_LEVEL_PARAM);
      speckleRailing.path = CurveListToSpeckle(revitRailing.GetPath());

      GetAllRevitParamsAndIds(speckleRailing, revitRailing, new List<string> { "STAIRS_RAILING_BASE_LEVEL_PARAM" });

      speckleRailing.displayMesh = GetElementDisplayMesh(revitRailing, new Options() { DetailLevel = ViewDetailLevel.Fine, ComputeReferences = false });

      return speckleRailing;
    }

  }
}
