﻿
using Autodesk.Revit.DB;
using Objects.BuiltElements.Revit;
using Objects.Geometry;
using Speckle.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using DB = Autodesk.Revit.DB.Architecture;

namespace Objects.Converter.Revit
{
  public partial class ConverterRevit
  {
    //NOTE: BuildingPad cannot be created from the API AFAIK
    private BuildingPad BuildingPadToSpeckle(DB.BuildingPad revitPad)
    {
      var profiles = GetProfiles(revitPad);

      var specklePad = new BuildingPad();
      specklePad.type = Doc.GetElement(revitPad.GetTypeId()).Name;
      specklePad.outline = profiles[0];
      if (profiles.Count > 1)
      {
        specklePad.voids = profiles.Skip(1).ToList();
      }

      specklePad.level = ConvertAndCacheLevel(revitPad, BuiltInParameter.LEVEL_PARAM);

      GetAllRevitParamsAndIds(specklePad, revitPad, new List<string> { "LEVEL_PARAM" });

      specklePad.displayMesh = GetElementDisplayMesh(revitPad, new Options() { DetailLevel = ViewDetailLevel.Fine, ComputeReferences = false });

      return specklePad;
    }
  }
}
