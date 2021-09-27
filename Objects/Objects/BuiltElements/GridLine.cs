﻿using Objects.Geometry;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.BuiltElements
{
  public class GridLine : Base
  {
    public ICurve baseLine { get; set; }
    public string label { get; set; }

    public string units { get; set; }

    public GridLine() { }

    [SchemaInfo("GridLine", "Creates a Speckle grid line", "BIM", "Other")]
    public GridLine([SchemaParamInfo("NOTE: only Line and Arc curves are supported in Revit")][SchemaMainParam] ICurve baseLine)
    {
      this.baseLine = baseLine;
    }
  }
}
