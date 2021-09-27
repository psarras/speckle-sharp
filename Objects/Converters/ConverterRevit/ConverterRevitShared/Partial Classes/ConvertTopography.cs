﻿using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Objects.BuiltElements;
using Objects.BuiltElements.Revit;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Objects.Converter.Revit
{
  public partial class ConverterRevit
  {
    public ApplicationPlaceholderObject TopographyToNative(Topography speckleSurface)
    {
      var docObj = GetExistingElementByApplicationId(((Base)speckleSurface).applicationId);

      var pts = new List<XYZ>();
      for (int i = 0; i < speckleSurface.displayMesh.vertices.Count; i += 3)
      {
        var point = new Geometry.Point(speckleSurface.displayMesh.vertices[i], speckleSurface.displayMesh.vertices[i + 1], speckleSurface.displayMesh.vertices[i + 2], speckleSurface.displayMesh.units);
        pts.Add(PointToNative(point));
      }

      if (docObj != null)
      {
        Doc.Delete(docObj.Id);
      }

      var revitSurface = TopographySurface.Create(Doc, pts);
      if (speckleSurface is RevitTopography rt)
      {
        SetInstanceParameters(revitSurface, rt);
      }

      return new ApplicationPlaceholderObject { applicationId = ((Base)speckleSurface).applicationId, ApplicationGeneratedId = revitSurface.UniqueId, NativeObject = revitSurface };
    }

    public RevitTopography TopographyToSpeckle(TopographySurface revitTopo)
    {
      var speckleTopo = new RevitTopography();
      speckleTopo.displayMesh = GetElementMesh(revitTopo);
      GetAllRevitParamsAndIds(speckleTopo, revitTopo);

      return speckleTopo;
    }
  }
}