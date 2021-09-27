﻿using Speckle.Newtonsoft.Json;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;
using Objects.Geometry;
using Objects.Structural.Geometry;
using Objects.Structural.Properties;

namespace Objects.Structural.GSA.Geometry
{
    public class GSAAssembly : Base
    {
        public int nativeId { get; set; } //equiv to num record of gwa keyword        
        public string name { get; set; }
        public List<Base> entities { get; set; } //nodes, elements, members

        [DetachProperty]
        public GSANode end1Node { get; set; }

        [DetachProperty]
        public GSANode end2Node { get; set; }

        [DetachProperty]
        public GSANode orientationNode { get; set; }
        public double sizeY { get; set; }
        public double sizeZ { get; set; }
        public string curveType { get; set; } // enum? circular or lagrange sufficient?
        public string curveOrder { get; set; }
        public string pointDefinition { get; set; } // enum as well? points and spacing to start? 
        public double points { get; set; } // or make this Base type to accomdate storey list and explicit range? or add sep property for those cases?

        public GSAAssembly() { }

        public GSAAssembly(int nativeId, string name, List<Base> entities, GSANode end1Node, GSANode end2Node, GSANode orientationNode, double sizeY, double sizeZ, string curveType, string curveOrder, string pointDefinition, double points)
        {
            this.nativeId = nativeId;
            this.name = name;
            this.entities = entities;
            this.end1Node = end1Node;
            this.end2Node = end2Node;
            this.orientationNode = orientationNode;
            this.sizeY = sizeY;
            this.sizeZ = sizeZ;
            this.curveType = curveType;
            this.curveOrder = curveOrder;
            this.pointDefinition = pointDefinition;
            this.points = points;
        }
    }
}
