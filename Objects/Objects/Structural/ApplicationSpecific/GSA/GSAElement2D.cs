﻿using Speckle.Newtonsoft.Json;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;
using Objects.Geometry;
using Objects.Structural.Geometry;
using Objects.Structural.Properties;

namespace Objects.Structural.GSA.Geometry
{
    public class GSAElement2D : Element2D
    {
        public int nativeId { get; set; }
        public int group { get; set; }
        public string colour { get; set; }
        public bool isDummy { get; set; }
        public GSAElement2D() { }

        [SchemaInfo("GSAElement2D", "Creates a Speckle structural 2D element for GSA", "GSA", "Geometry")]
        public GSAElement2D(int nativeId, Mesh baseMesh, Property2D property, ElementType2D type, string name = null, double offset = 0, double orientationAngle = 0, int group = 0, string colour = "NO_RGB", bool isDummy = false)
        {
            this.nativeId = nativeId;
            this.baseMesh = baseMesh;
            this.property = property;
            this.type = type;
            this.name = name;
            this.nativeId = nativeId;
            this.offset = offset;
            this.orientationAngle = orientationAngle;
            this.group = group;
            this.colour = colour;
            this.isDummy = isDummy;
        }
    }
}
