

using System;
using Grasshopper.Kernel;
using ConnectorGrasshopperUtils;

namespace ConnectorGrasshopper {

// This is generated code:
public class AdaptiveComponentSchemaComponent: CreateSchemaObjectBase {
     
    public AdaptiveComponentSchemaComponent(): base("AdaptiveComponent", "AdaptiveComponent", "Creates a Revit adaptive component by points", "Speckle 2 Revit", "Families") { }
    
    public override Guid ComponentGuid => new Guid("71420d27-62d1-f158-edab-a89e54604d76");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.AdaptiveComponent.ctor(System.String,System.String,System.Collections.Generic.List`1[Objects.Geometry.Point],System.Boolean,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.AdaptiveComponent");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class AngleSchemaComponent: CreateSchemaObjectBase {
     
    public AngleSchemaComponent(): base("Angle", "Angle", "Creates a Speckle structural angle section profile", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("91df837b-3162-a0de-724d-ea182e77e68c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Angle.ctor(System.String,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.Profiles.SectionProfile+Angle");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class AreaSchemaComponent: CreateSchemaObjectBase {
     
    public AreaSchemaComponent(): base("Area", "Area", "Creates a Speckle area", "Speckle 2 BIM", "Other") { }
    
    public override Guid ComponentGuid => new Guid("b98bd134-1ebd-b805-821c-465f1a25fb4e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Area.ctor(System.String,System.String,Objects.BuiltElements.Level,Objects.Geometry.Point)","Objects.BuiltElements.Area");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class AxisSchemaComponent: CreateSchemaObjectBase {
     
    public AxisSchemaComponent(): base("Axis", "Axis", "Creates a Speckle structural axis (a user-defined axis)", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("38fdc896-0404-4961-120f-6e373d19edbc");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Axis.ctor(System.String,Objects.Structural.AxisType,Objects.Geometry.Plane)","Objects.Structural.Geometry.Axis");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class BeamSchemaComponent: CreateSchemaObjectBase {
     
    public BeamSchemaComponent(): base("Beam", "Beam", "Creates a Speckle beam", "Speckle 2 BIM", "Structure") { }
    
    public override Guid ComponentGuid => new Guid("5c0a392e-bc1c-cf28-0048-a99ee090ffa1");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Beam.ctor(Objects.ICurve)","Objects.BuiltElements.Beam");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class BeamLoadSchemaComponent: CreateSchemaObjectBase {
     
    public BeamLoadSchemaComponent(): base("BeamLoad", "BeamLoad", "Creates a Speckle structural beam (1D elem/member) load", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("7263ed7e-4cf8-f40f-77bc-2920418dec4c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.BeamLoad.ctor(Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Structural.Loading.BeamLoadType,Objects.Structural.Loading.LoadDirection,Objects.Structural.LoadAxisType,System.Collections.Generic.List`1[System.Double],System.Collections.Generic.List`1[System.Double],System.Boolean)","Objects.Structural.Loading.BeamLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class BeamLoad1SchemaComponent: CreateSchemaObjectBase {
     
    public BeamLoad1SchemaComponent(): base("BeamLoad (user-defined axis)", "BeamLoad (user-defined axis)", "Creates a Speckle structural beam (1D elem/member) load (specified for a user-defined axis)", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("0736f9ba-ba9e-d250-bdac-556bb5947071");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.BeamLoad.ctor(Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Structural.Loading.BeamLoadType,Objects.Structural.Loading.LoadDirection,Objects.Structural.Geometry.Axis,System.Collections.Generic.List`1[System.Double],System.Collections.Generic.List`1[System.Double],System.Boolean)","Objects.Structural.Loading.BeamLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class BraceSchemaComponent: CreateSchemaObjectBase {
     
    public BraceSchemaComponent(): base("Brace", "Brace", "Creates a Speckle brace", "Speckle 2 BIM", "Structure") { }
    
    public override Guid ComponentGuid => new Guid("cf5f1dad-80cd-d499-2ef7-6ae1f8d34a5c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Brace.ctor(Objects.ICurve)","Objects.BuiltElements.Brace");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class CaseSchemaComponent: CreateSchemaObjectBase {
     
    public CaseSchemaComponent(): base("AnalysisCase", "AnalysisCase", "Creates a Speckle structural analysis case for GSA", "Speckle 2 GSA", "Analysis") { }
    
    public override Guid ComponentGuid => new Guid("14616ec2-6474-a9c5-492a-37aaac1948bb");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Analysis.Case.ctor(System.Int32,System.String,Objects.Structural.GSA.Analysis.Task,System.String)","Objects.Structural.GSA.Analysis.Case");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class CatalogueSchemaComponent: CreateSchemaObjectBase {
     
    public CatalogueSchemaComponent(): base("Catalogue (by description)", "Catalogue (by description)", "Creates a Speckle structural section profile based on a catalogue section description", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("7e0f97be-7297-64f8-fc85-f43623186129");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Catalogue.ctor(System.String)","Objects.Structural.Properties.Profiles.SectionProfile+Catalogue");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Catalogue1SchemaComponent: CreateSchemaObjectBase {
     
    public Catalogue1SchemaComponent(): base("Catalogue", "Catalogue", "Creates a Speckle structural section profile", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("1b5a50a5-4b3d-1018-8e3f-bb34ad0af7ff");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Catalogue.ctor(System.String,System.String,System.String,System.String)","Objects.Structural.Properties.Profiles.SectionProfile+Catalogue");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class CeilingSchemaComponent: CreateSchemaObjectBase {
     
    public CeilingSchemaComponent(): base("Ceiling", "Ceiling", "Creates a Speckle ceiling", "Speckle 2 BIM", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("91b38d18-dd01-dfc7-f11d-e3d2c118ff0b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Ceiling.ctor(Objects.ICurve,System.Collections.Generic.List`1[Objects.ICurve],System.Collections.Generic.List`1[Speckle.Core.Models.Base])","Objects.BuiltElements.Ceiling");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ChannelSchemaComponent: CreateSchemaObjectBase {
     
    public ChannelSchemaComponent(): base("Channel", "Channel", "Creates a Speckle structural channel section profile", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("40336db1-decb-2ad6-6680-01c457f0f31d");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Channel.ctor(System.String,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.Profiles.SectionProfile+Channel");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class CircularSchemaComponent: CreateSchemaObjectBase {
     
    public CircularSchemaComponent(): base("Circular", "Circular", "Creates a Speckle structural circular section profile", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("fbf190e3-c085-dfc9-3b49-bcda58ab931f");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Circular.ctor(System.String,System.Double,System.Double)","Objects.Structural.Properties.Profiles.SectionProfile+Circular");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ColumnSchemaComponent: CreateSchemaObjectBase {
     
    public ColumnSchemaComponent(): base("Column", "Column", "Creates a Speckle column", "Speckle 2 BIM", "Structure") { }
    
    public override Guid ComponentGuid => new Guid("d92fc447-81b6-e595-1905-6239ea13a49b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Column.ctor(Objects.ICurve)","Objects.BuiltElements.Column");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ConcreteSchemaComponent: CreateSchemaObjectBase {
     
    public ConcreteSchemaComponent(): base("Concrete", "Concrete", "Creates a Speckle structural material for concrete (to be used in structural analysis models)", "Speckle 2 Structural", "Materials") { }
    
    public override Guid ComponentGuid => new Guid("104f1e8d-a551-bb84-e671-3394bc6a4c2b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Materials.Concrete.ctor(System.String,System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Materials.Concrete");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class DetailCurveSchemaComponent: CreateSchemaObjectBase {
     
    public DetailCurveSchemaComponent(): base("DetailCurve", "DetailCurve", "Creates a Revit detail curve", "Speckle 2 Revit", "Curves") { }
    
    public override Guid ComponentGuid => new Guid("4752d321-22cc-2d9e-dc6d-e3cf8e70c612");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.Curve.DetailCurve.ctor(Objects.ICurve,System.String,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.Curve.DetailCurve");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class DirectShapeSchemaComponent: CreateSchemaObjectBase {
     
    public DirectShapeSchemaComponent(): base("DirectShape by base geometries", "DirectShape by base geometries", "Creates a Revit DirectShape using a list of base geometry objects.", "Speckle 2 Revit", "Families") { }
    
    public override Guid ComponentGuid => new Guid("870d9670-cbf5-06d2-f371-e1e49212b063");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.DirectShape.ctor(System.String,Objects.BuiltElements.Revit.RevitCategory,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.DirectShape");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class DuctSchemaComponent: CreateSchemaObjectBase {
     
    public DuctSchemaComponent(): base("Duct", "Duct", "Creates a Speckle duct", "Speckle 2 BIM", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("51d40791-43ea-a8e7-ef13-e9bfdf9cd893");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Duct.ctor(Objects.Geometry.Line,System.Double,System.Double,System.Double,System.Double)","Objects.BuiltElements.Duct");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Element1DSchemaComponent: CreateSchemaObjectBase {
     
    public Element1DSchemaComponent(): base("Element1D (from local axis)", "Element1D (from local axis)", "Creates a Speckle structural 1D element (from local axis)", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("9fffb53b-3465-7a5b-4839-91cfdcb86f63");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Element1D.ctor(Objects.ICurve,Objects.Structural.Properties.Property1D,Objects.Structural.Geometry.ElementType1D,System.String,Objects.Structural.Geometry.Restraint,Objects.Structural.Geometry.Restraint,Objects.Geometry.Vector,Objects.Geometry.Vector,Objects.Geometry.Plane)","Objects.Structural.Geometry.Element1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Element1D1SchemaComponent: CreateSchemaObjectBase {
     
    public Element1D1SchemaComponent(): base("Element1D (from orientation node and angle)", "Element1D (from orientation node and angle)", "Creates a Speckle structural 1D element (from orientation node and angle)", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("6cb2d683-3116-0246-18b0-1bd35ed8fcc6");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Element1D.ctor(Objects.ICurve,Objects.Structural.Properties.Property1D,Objects.Structural.Geometry.ElementType1D,System.String,Objects.Structural.Geometry.Restraint,Objects.Structural.Geometry.Restraint,Objects.Geometry.Vector,Objects.Geometry.Vector,Objects.Structural.Geometry.Node,System.Double)","Objects.Structural.Geometry.Element1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Element2DSchemaComponent: CreateSchemaObjectBase {
     
    public Element2DSchemaComponent(): base("Element2D", "Element2D", "Creates a Speckle structural 2D element", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("0927879c-d28c-1c35-0d3f-4ba8e324ec39");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Element2D.ctor(Objects.Geometry.Mesh,Objects.Structural.Properties.Property2D,Objects.Structural.Geometry.ElementType2D,System.Double,System.Double)","Objects.Structural.Geometry.Element2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Element3DSchemaComponent: CreateSchemaObjectBase {
     
    public Element3DSchemaComponent(): base("Element3D", "Element3D", "Creates a Speckle structural 3D element", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("54b79bd6-7a50-2107-afd5-f9b18346f8ea");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Element3D.ctor(Objects.Geometry.Mesh,Objects.Structural.Properties.Property3D,Objects.Structural.Geometry.ElementType3D,System.String,System.Double)","Objects.Structural.Geometry.Element3D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ExplicitSchemaComponent: CreateSchemaObjectBase {
     
    public ExplicitSchemaComponent(): base("Explicit", "Explicit", "Creates a Speckle structural section profile based on explicitly defining geometric properties", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("e15a7edd-4559-0bb6-3559-48b72c43da2e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Explicit.ctor(System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.Profiles.SectionProfile+Explicit");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class FaceLoadSchemaComponent: CreateSchemaObjectBase {
     
    public FaceLoadSchemaComponent(): base("FaceLoad", "FaceLoad", "Creates a Speckle structural face (2D elem/member) load", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("93febde5-cf71-d53f-6e20-8eea2201c3c3");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.FaceLoad.ctor(Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Structural.Loading.AreaLoadType,Objects.Structural.Loading.LoadDirection,Objects.Structural.LoadAxisType,System.Collections.Generic.List`1[System.Double],System.Collections.Generic.List`1[System.Double],System.Boolean)","Objects.Structural.Loading.FaceLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class FamilyInstanceSchemaComponent: CreateSchemaObjectBase {
     
    public FamilyInstanceSchemaComponent(): base("FamilyInstance", "FamilyInstance", "Creates a Revit family instance", "Speckle 2 Revit", "Families") { }
    
    public override Guid ComponentGuid => new Guid("266c4d84-3f2a-9129-565b-0ddb1e5bdac4");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.FamilyInstance.ctor(Objects.Geometry.Point,System.String,System.String,Objects.BuiltElements.Level,System.Double,System.Boolean,System.Boolean,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.FamilyInstance");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class FloorSchemaComponent: CreateSchemaObjectBase {
     
    public FloorSchemaComponent(): base("Floor", "Floor", "Creates a Speckle floor", "Speckle 2 BIM", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("74c5b6bf-257e-8d4e-d9cb-7dc2c7ae3f22");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Floor.ctor(Objects.ICurve,System.Collections.Generic.List`1[Objects.ICurve],System.Collections.Generic.List`1[Speckle.Core.Models.Base])","Objects.BuiltElements.Floor");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class FreeformElementSchemaComponent: CreateSchemaObjectBase {
     
    public FreeformElementSchemaComponent(): base("Freeform element", "Freeform element", "Creates a Revit Freeform element using a Brep or a Mesh.", "Speckle 2 Revit", "Families") { }
    
    public override Guid ComponentGuid => new Guid("b24dc861-1c3c-a509-bc8b-560e9f7d503e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.FreeformElement.ctor(Speckle.Core.Models.Base,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.FreeformElement");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GravityLoadSchemaComponent: CreateSchemaObjectBase {
     
    public GravityLoadSchemaComponent(): base("GravityLoad", "GravityLoad", "Creates a Speckle structural gravity load (applied to all nodes and elements)", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("db906616-5444-425d-8d03-36babe8c6ce9");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.GravityLoad.ctor(System.String,Objects.Structural.Loading.LoadCase,Objects.Geometry.Vector)","Objects.Structural.Loading.GravityLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GravityLoad1SchemaComponent: CreateSchemaObjectBase {
     
    public GravityLoad1SchemaComponent(): base("GravityLoad (specified elements)", "GravityLoad (specified elements)", "Creates a Speckle structural gravity load (applied to specified elements)", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("651d200a-8373-351c-87e1-02fb7cff46d8");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.GravityLoad.ctor(System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Geometry.Vector)","Objects.Structural.Loading.GravityLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GravityLoad2SchemaComponent: CreateSchemaObjectBase {
     
    public GravityLoad2SchemaComponent(): base("GravityLoad (specified elements and nodes)", "GravityLoad (specified elements and nodes)", "Creates a Speckle structural gravity load (applied to specified nodes and elements)", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("27a40bf0-0a9a-d1e2-fc33-3cfca6f953c8");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.GravityLoad.ctor(System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Geometry.Vector)","Objects.Structural.Loading.GravityLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GridLineSchemaComponent: CreateSchemaObjectBase {
     
    public GridLineSchemaComponent(): base("GridLine", "GridLine", "Creates a Speckle grid line", "Speckle 2 BIM", "Other") { }
    
    public override Guid ComponentGuid => new Guid("b2d4bd71-86a7-c142-7220-d9ed2ee7b02e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.GridLine.ctor(Objects.ICurve)","Objects.BuiltElements.GridLine");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSABeamLoadSchemaComponent: CreateSchemaObjectBase {
     
    public GSABeamLoadSchemaComponent(): base("GSABeamLoad", "GSABeamLoad", "Creates a Speckle structural beam (1D elem/member) load for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("dfc5c221-fb0e-3931-65f5-46eff58bedb9");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSABeamLoad.ctor(System.Int32,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Structural.Loading.BeamLoadType,Objects.Structural.Loading.LoadDirection,Objects.Structural.LoadAxisType,System.Collections.Generic.List`1[System.Double],System.Collections.Generic.List`1[System.Double],System.Boolean)","Objects.Structural.GSA.Loading.GSABeamLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSABeamLoad1SchemaComponent: CreateSchemaObjectBase {
     
    public GSABeamLoad1SchemaComponent(): base("GSABeamLoad (user-defined axis)", "GSABeamLoad (user-defined axis)", "Creates a Speckle structural beam (1D elem/member) load (specified for a user-defined axis) for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("5a94f406-cd3c-5deb-06b7-1f7adca54041");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSABeamLoad.ctor(System.Int32,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Structural.Loading.BeamLoadType,Objects.Structural.Loading.LoadDirection,Objects.Structural.Geometry.Axis,System.Collections.Generic.List`1[System.Double],System.Collections.Generic.List`1[System.Double],System.Boolean)","Objects.Structural.GSA.Loading.GSABeamLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAElement1DSchemaComponent: CreateSchemaObjectBase {
     
    public GSAElement1DSchemaComponent(): base("GSAElement1D (from local axis)", "GSAElement1D (from local axis)", "Creates a Speckle structural 1D element for GSA (from local axis)", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("8b41c9e5-f24b-f0bc-7b62-169f839883ec");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAElement1D.ctor(System.Int32,Objects.ICurve,Objects.Structural.Properties.Property1D,Objects.Structural.Geometry.ElementType1D,Objects.Structural.Geometry.Restraint,Objects.Structural.Geometry.Restraint,Objects.Geometry.Vector,Objects.Geometry.Vector,Objects.Geometry.Plane)","Objects.Structural.GSA.Geometry.GSAElement1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAElement1D1SchemaComponent: CreateSchemaObjectBase {
     
    public GSAElement1D1SchemaComponent(): base("GSAElement1D (from orientation node and angle)", "GSAElement1D (from orientation node and angle)", "Creates a Speckle structural 1D element for GSA (from orientation node and angle)", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("d3ff71ed-34b8-6f9b-7ebc-50ff8195d1b2");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAElement1D.ctor(System.Int32,Objects.ICurve,Objects.Structural.Properties.Property1D,Objects.Structural.Geometry.ElementType1D,Objects.Structural.Geometry.Restraint,Objects.Structural.Geometry.Restraint,Objects.Geometry.Vector,Objects.Geometry.Vector,Objects.Structural.Geometry.Node,System.Double)","Objects.Structural.GSA.Geometry.GSAElement1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAElement2DSchemaComponent: CreateSchemaObjectBase {
     
    public GSAElement2DSchemaComponent(): base("GSAElement2D", "GSAElement2D", "Creates a Speckle structural 2D element for GSA", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("9a1c5132-a785-c389-fe5f-441820f07446");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAElement2D.ctor(System.Int32,Objects.Geometry.Mesh,Objects.Structural.Properties.Property2D,Objects.Structural.Geometry.ElementType2D,System.String,System.Double,System.Double,System.Int32,System.String,System.Boolean)","Objects.Structural.GSA.Geometry.GSAElement2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAElement3DSchemaComponent: CreateSchemaObjectBase {
     
    public GSAElement3DSchemaComponent(): base("GSAElement3D", "GSAElement3D", "Creates a Speckle structural 3D element for GSA", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("3fb3f410-62f0-f972-de47-4e55d8aee0b6");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAElement3D.ctor(System.Int32,Objects.Geometry.Mesh,Objects.Structural.Properties.Property3D,Objects.Structural.Geometry.ElementType3D,System.String,System.Double,System.Int32,System.String,System.Boolean)","Objects.Structural.GSA.Geometry.GSAElement3D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAFaceLoadSchemaComponent: CreateSchemaObjectBase {
     
    public GSAFaceLoadSchemaComponent(): base("GSAFaceLoad", "GSAFaceLoad", "Creates a Speckle structural face (2D elem/member) load for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("d822d37c-4f44-578a-2d27-8511dd5be6fb");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSAFaceLoad.ctor(System.Int32,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Structural.Loading.AreaLoadType,Objects.Structural.Loading.LoadDirection,Objects.Structural.LoadAxisType,System.Collections.Generic.List`1[System.Double],System.Collections.Generic.List`1[System.Double],System.Boolean)","Objects.Structural.GSA.Loading.GSAFaceLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAGravityLoadSchemaComponent: CreateSchemaObjectBase {
     
    public GSAGravityLoadSchemaComponent(): base("GSAGravityLoad", "GSAGravityLoad", "Creates a Speckle structural gravity load (applied to all nodes and elements) for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("ca9b2feb-a6c9-f3b7-d35a-207491fb259c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSAGravityLoad.ctor(System.Int32,System.String,Objects.Structural.Loading.LoadCase,Objects.Geometry.Vector)","Objects.Structural.GSA.Loading.GSAGravityLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAGravityLoad1SchemaComponent: CreateSchemaObjectBase {
     
    public GSAGravityLoad1SchemaComponent(): base("GSAGravityLoad (specified elements)", "GSAGravityLoad (specified elements)", "Creates a Speckle structural gravity load (applied to specified elements) for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("528782db-6c39-6cda-780e-606819faabfb");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSAGravityLoad.ctor(System.Int32,System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Geometry.Vector)","Objects.Structural.GSA.Loading.GSAGravityLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAGravityLoad2SchemaComponent: CreateSchemaObjectBase {
     
    public GSAGravityLoad2SchemaComponent(): base("GSAGravityLoad (specified elements and nodes)", "GSAGravityLoad (specified elements and nodes)", "Creates a Speckle structural gravity load (applied to specified nodes and elements) for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("d170808b-8fdc-4dff-8ee6-db4d7ad31baa");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSAGravityLoad.ctor(System.Int32,System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Speckle.Core.Models.Base],Objects.Geometry.Vector,System.String)","Objects.Structural.GSA.Loading.GSAGravityLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSALoadCaseSchemaComponent: CreateSchemaObjectBase {
     
    public GSALoadCaseSchemaComponent(): base("GSALoadCase", "GSALoadCase", "Creates a Speckle structural load case for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("3d862f90-6804-d75c-a0e2-8e90c9b190db");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSALoadCase.ctor(System.Int32,System.String,Objects.Structural.Loading.LoadType,System.String,Objects.Structural.Loading.ActionType,System.String)","Objects.Structural.GSA.Loading.GSALoadCase");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSALoadCombinationSchemaComponent: CreateSchemaObjectBase {
     
    public GSALoadCombinationSchemaComponent(): base("GSALoadCombination", "GSALoadCombination", "Creates a Speckle load combination for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("a79c8825-221a-d44f-5faa-b257f3f6c98e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSALoadCombination.ctor(System.Int32,System.String,System.Collections.Generic.List`1[Objects.Structural.Loading.LoadCase],System.Collections.Generic.List`1[System.Double])","Objects.Structural.GSA.Loading.GSALoadCombination");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAMember1DSchemaComponent: CreateSchemaObjectBase {
     
    public GSAMember1DSchemaComponent(): base("GSAMember1D (from local axis)", "GSAMember1D (from local axis)", "Creates a Speckle structural 1D member for GSA (from local axis)", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("e86d92aa-cefd-5a09-138d-a1cd1fe36e7d");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAMember1D.ctor(System.Int32,Objects.ICurve,Objects.Structural.Properties.Property1D,Objects.Structural.Geometry.ElementType1D,Objects.Structural.Geometry.Restraint,Objects.Structural.Geometry.Restraint,Objects.Geometry.Vector,Objects.Geometry.Vector,Objects.Geometry.Plane)","Objects.Structural.GSA.Geometry.GSAMember1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAMember1D1SchemaComponent: CreateSchemaObjectBase {
     
    public GSAMember1D1SchemaComponent(): base("GSAMember1D (from orientation node and angle)", "GSAMember1D (from orientation node and angle)", "Creates a Speckle structural 1D member for GSA (from orientation node and angle)", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("7c4f3597-5d45-eb1e-c7e9-c3a4dfb9a240");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAMember1D.ctor(System.Int32,Objects.ICurve,Objects.Structural.Properties.Property1D,Objects.Structural.Geometry.ElementType1D,Objects.Structural.Geometry.Restraint,Objects.Structural.Geometry.Restraint,Objects.Geometry.Vector,Objects.Geometry.Vector,Objects.Structural.Geometry.Node,System.Double)","Objects.Structural.GSA.Geometry.GSAMember1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAMember2DSchemaComponent: CreateSchemaObjectBase {
     
    public GSAMember2DSchemaComponent(): base("GSAMember2D (by mesh)", "GSAMember2D (by mesh)", "Creates a Speckle structural 2D member for GSA", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("3b367574-1c20-77d0-c4e8-46979f8a3f42");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAMember2D.ctor(Objects.Geometry.Mesh,Objects.Structural.Properties.Property2D,Objects.Structural.Geometry.ElementType2D,System.Double,System.Double)","Objects.Structural.GSA.Geometry.GSAMember2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAMember2D1SchemaComponent: CreateSchemaObjectBase {
     
    public GSAMember2D1SchemaComponent(): base("GSAMember2D (by perimeter)", "GSAMember2D (by perimeter)", "Creates a Speckle structural 2D member for GSA", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("782e51ae-a3ba-89df-0150-076a456f7e71");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSAMember2D.ctor(System.Collections.Generic.List`1[Objects.Structural.Geometry.Node],Objects.Structural.Properties.Property2D,Objects.Structural.Geometry.ElementType2D,System.Collections.Generic.List`1[System.Collections.Generic.List`1[Objects.Structural.Geometry.Node]],System.Double,System.Double)","Objects.Structural.GSA.Geometry.GSAMember2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSANodeSchemaComponent: CreateSchemaObjectBase {
     
    public GSANodeSchemaComponent(): base("GSANode", "GSANode", "Creates a Speckle structural node for GSA", "Speckle 2 GSA", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("3b6c01e9-4d99-90a8-357e-def8c043faa0");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Geometry.GSANode.ctor(System.Int32,Objects.Geometry.Point,Objects.Structural.Geometry.Restraint,Objects.Geometry.Plane,Objects.Structural.Properties.PropertySpring,Objects.Structural.Properties.PropertyMass,Objects.Structural.Properties.PropertyDamper,System.Double,System.String)","Objects.Structural.GSA.Geometry.GSANode");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSANodeLoadSchemaComponent: CreateSchemaObjectBase {
     
    public GSANodeLoadSchemaComponent(): base("GSANodeLoad", "GSANodeLoad", "Creates a Speckle node load for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("6eb2588c-8cf1-abdb-e336-e9824c944016");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSANodeLoad.ctor(System.Int32,System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Objects.Structural.GSA.Geometry.GSANode],Objects.Structural.Loading.LoadDirection,System.Double)","Objects.Structural.GSA.Loading.GSANodeLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSANodeLoad1SchemaComponent: CreateSchemaObjectBase {
     
    public GSANodeLoad1SchemaComponent(): base("GSANodeLoad (user-defined axis)", "GSANodeLoad (user-defined axis)", "Creates a Speckle node load (user-defined axis) for GSA", "Speckle 2 GSA", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("b2452af5-18f4-c42b-85c3-cc2178be6a27");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Loading.GSANodeLoad.ctor(System.Int32,System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Objects.Structural.Geometry.Node],Objects.Structural.Geometry.Axis,Objects.Structural.Loading.LoadDirection,System.Double)","Objects.Structural.GSA.Loading.GSANodeLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAProperty1DSchemaComponent: CreateSchemaObjectBase {
     
    public GSAProperty1DSchemaComponent(): base("GSAProperty1D", "GSAProperty1D", "Creates a Speckle structural 1D element property for GSA", "Speckle 2 GSA", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("347df789-96b7-21f2-fc2f-5bfd26dfbe6f");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Properties.GSAProperty1D.ctor(System.Int32,System.String,Objects.Structural.Materials.Material,Objects.Structural.Properties.Profiles.SectionProfile,System.Double,System.Double)","Objects.Structural.GSA.Properties.GSAProperty1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class GSAProperty2DSchemaComponent: CreateSchemaObjectBase {
     
    public GSAProperty2DSchemaComponent(): base("GSAProperty2D", "GSAProperty2D", "Creates a Speckle structural 2D element property for GSA", "Speckle 2 GSA", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("562e2664-bdf3-8b98-6e09-cc6584cf2146");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Properties.GSAProperty2D.ctor(System.Int32,System.String,Objects.Structural.Materials.Material,System.Double)","Objects.Structural.GSA.Properties.GSAProperty2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ISectionSchemaComponent: CreateSchemaObjectBase {
     
    public ISectionSchemaComponent(): base("ISection", "ISection", "Creates a Speckle structural I section profile", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("321c4075-d631-8957-9daf-244e6374d73e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+ISection.ctor(System.String,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.Profiles.SectionProfile+ISection");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class LevelSchemaComponent: CreateSchemaObjectBase {
     
    public LevelSchemaComponent(): base("Level", "Level", "Creates a Speckle level", "Speckle 2 BIM", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("04fca79a-ae5b-6ac4-581d-79438351a4e8");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Level.ctor(System.String,System.Double)","Objects.BuiltElements.Level");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class LoadCaseSchemaComponent: CreateSchemaObjectBase {
     
    public LoadCaseSchemaComponent(): base("LoadCase", "LoadCase", "Creates a Speckle structural load case", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("6436c6fd-e4e3-b78a-75f5-d967dc2550fc");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.LoadCase.ctor(System.String,Objects.Structural.Loading.LoadType,System.String,Objects.Structural.Loading.ActionType,System.String)","Objects.Structural.Loading.LoadCase");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class LoadCombinationSchemaComponent: CreateSchemaObjectBase {
     
    public LoadCombinationSchemaComponent(): base("LoadCombination", "LoadCombination", "Creates a Speckle load combination", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("fdbef7a9-adba-eeed-cb4f-9d9799e16da7");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.LoadCombination.ctor(System.String,System.Collections.Generic.List`1[Objects.Structural.Loading.LoadCase],System.Collections.Generic.List`1[System.Double],Objects.Structural.Loading.CombinationType)","Objects.Structural.Loading.LoadCombination");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class MaterialSchemaComponent: CreateSchemaObjectBase {
     
    public MaterialSchemaComponent(): base("Material", "Material", "Creates a Speckle structural material", "Speckle 2 Structural", "Materials") { }
    
    public override Guid ComponentGuid => new Guid("a2ec94ca-c50c-01bf-3d12-0c8feb41004b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Materials.Material.ctor(System.String,Objects.Structural.MaterialType,System.String)","Objects.Structural.Materials.Material");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ModelSchemaComponent: CreateSchemaObjectBase {
     
    public ModelSchemaComponent(): base("Model", "Model", "Creates a Speckle structural model object", "Speckle 2 Structural", "Analysis") { }
    
    public override Guid ComponentGuid => new Guid("af7f27db-7897-fcad-1839-3b5213188ef8");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Analysis.Model.ctor(Objects.Structural.Analysis.ModelInfo,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Speckle.Core.Models.Base])","Objects.Structural.Analysis.Model");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ModelCurveSchemaComponent: CreateSchemaObjectBase {
     
    public ModelCurveSchemaComponent(): base("ModelCurve", "ModelCurve", "Creates a Revit model curve", "Speckle 2 Revit", "Curves") { }
    
    public override Guid ComponentGuid => new Guid("7aa6e073-6783-8e7b-eec2-7b7bb0420db2");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.Curve.ModelCurve.ctor(Objects.ICurve,System.String,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.Curve.ModelCurve");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ModelInfoSchemaComponent: CreateSchemaObjectBase {
     
    public ModelInfoSchemaComponent(): base("ModelInfo", "ModelInfo", "Creates a Speckle object which describes basic model and project information for a structural model", "Speckle 2 Structural", "Analysis") { }
    
    public override Guid ComponentGuid => new Guid("f9da0acf-e2ee-8d25-662f-f5b9928ff8aa");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Analysis.ModelInfo.ctor(System.String,System.String,System.String,System.String,Objects.Structural.Analysis.ModelSettings,System.String,System.String)","Objects.Structural.Analysis.ModelInfo");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ModelSettingsSchemaComponent: CreateSchemaObjectBase {
     
    public ModelSettingsSchemaComponent(): base("ModelSettings", "ModelSettings", "Creates a Speckle object which describes design and analysis settings for the structural model", "Speckle 2 Structural", "Analysis") { }
    
    public override Guid ComponentGuid => new Guid("2f8c73cc-0692-3fd9-a825-7e0677164975");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Analysis.ModelSettings.ctor(Objects.Structural.Analysis.ModelUnits,System.String,System.String,System.Double)","Objects.Structural.Analysis.ModelSettings");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ModelUnitsSchemaComponent: CreateSchemaObjectBase {
     
    public ModelUnitsSchemaComponent(): base("ModelUnits", "ModelUnits", "Creates a Speckle object which specifies the units associated with the model", "Speckle 2 Structural", "Analysis") { }
    
    public override Guid ComponentGuid => new Guid("6c3340f9-3493-5e35-7272-e6acd0eefa85");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Analysis.ModelUnits.ctor(Objects.Structural.Analysis.UnitsType)","Objects.Structural.Analysis.ModelUnits");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ModelUnits1SchemaComponent: CreateSchemaObjectBase {
     
    public ModelUnits1SchemaComponent(): base("ModelUnits (custom)", "ModelUnits (custom)", "Creates a Speckle object which specifies the units associated with the model", "Speckle 2 Structural", "Analysis") { }
    
    public override Guid ComponentGuid => new Guid("162c2a99-e4c9-314f-1833-f0e4a5c7451d");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Analysis.ModelUnits.ctor(System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String)","Objects.Structural.Analysis.ModelUnits");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class NodeSchemaComponent: CreateSchemaObjectBase {
     
    public NodeSchemaComponent(): base("Node", "Node", "Creates a Speckle structural node", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("dacc1582-c084-4685-981a-6f8f8d8663c8");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Node.ctor(Objects.Geometry.Point,System.String,Objects.Structural.Geometry.Restraint,Objects.Geometry.Plane)","Objects.Structural.Geometry.Node");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Node1SchemaComponent: CreateSchemaObjectBase {
     
    public Node1SchemaComponent(): base("Node with properties", "Node with properties", "Creates a Speckle structural node with spring, mass and/or damper properties", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("0a1cf6ed-072a-889a-7cbc-d2cc1d4b42f9");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Node.ctor(Objects.Geometry.Point,System.String,Objects.Structural.Geometry.Restraint,Objects.Geometry.Plane,Objects.Structural.Properties.PropertySpring,Objects.Structural.Properties.PropertyMass,Objects.Structural.Properties.PropertyDamper)","Objects.Structural.Geometry.Node");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class NodeLoadSchemaComponent: CreateSchemaObjectBase {
     
    public NodeLoadSchemaComponent(): base("NodeLoad", "NodeLoad", "Creates a Speckle node load", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("35e117b0-e039-7b2c-46e0-7b6a7d413009");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.NodeLoad.ctor(System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Objects.Structural.Geometry.Node],Objects.Structural.Loading.LoadDirection,System.Double)","Objects.Structural.Loading.NodeLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class NodeLoad1SchemaComponent: CreateSchemaObjectBase {
     
    public NodeLoad1SchemaComponent(): base("NodeLoad (user-defined axis)", "NodeLoad (user-defined axis)", "Creates a Speckle node load (user-defined axis)", "Speckle 2 Structural", "Loading") { }
    
    public override Guid ComponentGuid => new Guid("68f48dad-78db-1f2d-ddb7-abbc443c5193");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Loading.NodeLoad.ctor(System.String,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[Objects.Structural.Geometry.Node],Objects.Structural.Geometry.Axis,Objects.Structural.Loading.LoadDirection,System.Double)","Objects.Structural.Loading.NodeLoad");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ParameterSchemaComponent: CreateSchemaObjectBase {
     
    public ParameterSchemaComponent(): base("Parameter", "Parameter", "A Revit instance parameter to set on an element", "Speckle 2 Revit", "Families") { }
    
    public override Guid ComponentGuid => new Guid("706f3fe9-f499-b07f-b682-febedbe38c9c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.Parameter.ctor(System.String,System.Object)","Objects.BuiltElements.Revit.Parameter");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ParameterUpdaterSchemaComponent: CreateSchemaObjectBase {
     
    public ParameterUpdaterSchemaComponent(): base("ParameterUpdater", "ParameterUpdater", "Updates parameters on a Revit element by id", "Speckle 2 Revit", "Families") { }
    
    public override Guid ComponentGuid => new Guid("c4f5fc69-58e1-59f6-4dac-e31b738f7254");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.ParameterUpdater.ctor(System.String,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.ParameterUpdater");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PerimeterSchemaComponent: CreateSchemaObjectBase {
     
    public PerimeterSchemaComponent(): base("Perimeter", "Perimeter", "Creates a Speckle structural section profile defined by a perimeter curve and, if applicable, a list of void curves", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("63b41dcc-8f2e-b900-be8a-82a661e56f19");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Perimeter.ctor(System.String,Objects.ICurve,System.Collections.Generic.List`1[Objects.ICurve])","Objects.Structural.Properties.Profiles.SectionProfile+Perimeter");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PipeSchemaComponent: CreateSchemaObjectBase {
     
    public PipeSchemaComponent(): base("Pipe", "Pipe", "Creates a Speckle pipe", "Speckle 2 BIM", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("6892cf99-6913-7004-27ab-2cfb8435a644");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Pipe.ctor(Objects.ICurve,System.Double,System.Double,System.Double,System.Double)","Objects.BuiltElements.Pipe");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertySchemaComponent: CreateSchemaObjectBase {
     
    public PropertySchemaComponent(): base("Property", "Property", "Creates a Speckle structural property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("8f7a7ef0-dbe1-4085-a1e8-f602612698a5");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Property.ctor(System.String)","Objects.Structural.Properties.Property");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Property1DSchemaComponent: CreateSchemaObjectBase {
     
    public Property1DSchemaComponent(): base("Property1D (by name)", "Property1D (by name)", "Creates a Speckle structural 1D element property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("fa29bbb6-ab8f-a235-67da-c10fe9daa077");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Property1D.ctor(System.String)","Objects.Structural.Properties.Property1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Property1D1SchemaComponent: CreateSchemaObjectBase {
     
    public Property1D1SchemaComponent(): base("Property1D", "Property1D", "Creates a Speckle structural 1D element property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("301fb47d-9a12-ed72-4dbf-55d23ac5c432");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Property1D.ctor(System.String,Objects.Structural.Materials.Material,Objects.Structural.Properties.Profiles.SectionProfile)","Objects.Structural.Properties.Property1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Property2DSchemaComponent: CreateSchemaObjectBase {
     
    public Property2DSchemaComponent(): base("Property2D (by name)", "Property2D (by name)", "Creates a Speckle structural 2D element property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("b637985b-c4b8-0bbd-109b-7caf9fea829f");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Property2D.ctor(System.String)","Objects.Structural.Properties.Property2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Property2D1SchemaComponent: CreateSchemaObjectBase {
     
    public Property2D1SchemaComponent(): base("Property2D", "Property2D", "Creates a Speckle structural 2D element property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("a1f72576-5106-26da-625e-6c5dfe798b4f");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Property2D.ctor(System.String,Objects.Structural.Materials.Material,Objects.Structural.PropertyType2D,System.Double)","Objects.Structural.Properties.Property2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Property3DSchemaComponent: CreateSchemaObjectBase {
     
    public Property3DSchemaComponent(): base("Property3D (by name)", "Property3D (by name)", "Creates a Speckle structural 3D element property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("a1644434-1c43-113c-786e-c1942f56d205");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Property3D.ctor(System.String)","Objects.Structural.Properties.Property3D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Property3D1SchemaComponent: CreateSchemaObjectBase {
     
    public Property3D1SchemaComponent(): base("Property3D", "Property3D", "Creates a Speckle structural 3D element property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("5cc8c1d0-c3a7-0c95-f2b6-f8f7b4afdc95");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Property3D.ctor(System.String,Objects.Structural.PropertyType3D,Objects.Structural.Materials.Material)","Objects.Structural.Properties.Property3D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertyDamperSchemaComponent: CreateSchemaObjectBase {
     
    public PropertyDamperSchemaComponent(): base("PropertyDamper", "PropertyDamper", "Creates a Speckle structural damper property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("3d966901-7bcc-b5d0-c5c9-060ae5a2caff");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.PropertyDamper.ctor(System.String)","Objects.Structural.Properties.PropertyDamper");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertyDamper1SchemaComponent: CreateSchemaObjectBase {
     
    public PropertyDamper1SchemaComponent(): base("PropertyDamper (general)", "PropertyDamper (general)", "Creates a Speckle structural damper property (for 6 degrees of freedom)", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("10534d96-587f-e36f-3a97-db6b3fae6b53");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.PropertyDamper.ctor(System.String,Objects.Structural.PropertyTypeDamper,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.PropertyDamper");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertyMassSchemaComponent: CreateSchemaObjectBase {
     
    public PropertyMassSchemaComponent(): base("PropertyMass", "PropertyMass", "Creates a Speckle structural mass property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("2ab5d65b-d4d7-85fa-01bf-2384c5ce5666");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.PropertyMass.ctor(System.String)","Objects.Structural.Properties.PropertyMass");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertyMass1SchemaComponent: CreateSchemaObjectBase {
     
    public PropertyMass1SchemaComponent(): base("PropertyMass (general)", "PropertyMass (general)", "Creates a Speckle structural mass property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("66fb8c7a-804c-06d2-a6e0-5da60241dc48");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.PropertyMass.ctor(System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Boolean,System.Double,System.Double,System.Double)","Objects.Structural.Properties.PropertyMass");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertySpringSchemaComponent: CreateSchemaObjectBase {
     
    public PropertySpringSchemaComponent(): base("PropertySpring", "PropertySpring", "Creates a Speckle structural spring property", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("c83d3807-3ee9-9eb6-d6d3-ae472e5fce01");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.PropertySpring.ctor(System.String)","Objects.Structural.Properties.PropertySpring");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertySpring1SchemaComponent: CreateSchemaObjectBase {
     
    public PropertySpring1SchemaComponent(): base("PropertySpring (linear/elastic)", "PropertySpring (linear/elastic)", "Creates a Speckle structural spring property (linear/elastic spring)", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("03b67483-b251-b9f3-900a-e70c331314bb");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.PropertySpring.ctor(System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.PropertySpring");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class PropertySpring2SchemaComponent: CreateSchemaObjectBase {
     
    public PropertySpring2SchemaComponent(): base("PropertySpring (non-linear)", "PropertySpring (non-linear)", "Creates a Speckle structural spring property (non-linear spring)", "Speckle 2 Structural", "Properties") { }
    
    public override Guid ComponentGuid => new Guid("761c5a65-bec6-b6fb-1df5-c49cc427631b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.PropertySpring.ctor(System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.PropertySpring");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RectangularSchemaComponent: CreateSchemaObjectBase {
     
    public RectangularSchemaComponent(): base("Rectangular", "Rectangular", "Creates a Speckle structural rectangular section profile", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("2f4dce06-42d9-fe1e-5096-24debfd2fd4b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Rectangular.ctor(System.String,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.Profiles.SectionProfile+Rectangular");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RenderMaterialSchemaComponent: CreateSchemaObjectBase {
     
    public RenderMaterialSchemaComponent(): base("RenderMaterial", "RenderMaterial", "Creates a render material.", "Speckle 2 BIM", "Other") { }
    
    public override Guid ComponentGuid => new Guid("03a49484-4eba-6e08-5e96-b3b78ed13f70");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Other.RenderMaterial.ctor(System.Double,System.Double,System.Double,System.Nullable`1[System.Drawing.Color],System.Nullable`1[System.Drawing.Color])","Objects.Other.RenderMaterial");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RestraintSchemaComponent: CreateSchemaObjectBase {
     
    public RestraintSchemaComponent(): base("Restraint (by code)", "Restraint (by code)", "Creates a Speckle restraint object", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("4a117edf-50f0-9c11-6a80-e9692f15771b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Restraint.ctor(System.String)","Objects.Structural.Geometry.Restraint");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Restraint1SchemaComponent: CreateSchemaObjectBase {
     
    public Restraint1SchemaComponent(): base("Restraint (by code and stiffness)", "Restraint (by code and stiffness)", "Creates a Speckle restraint object (to describe support conditions with an explicit stiffness)", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("a57df1f7-6fbd-4c84-a9d6-bd2d84f73811");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Restraint.ctor(System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Geometry.Restraint");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Restraint2SchemaComponent: CreateSchemaObjectBase {
     
    public Restraint2SchemaComponent(): base("Restraint (by enum)", "Restraint (by enum)", "Creates a Speckle restraint object (for pinned condition or fixed condition)", "Speckle 2 Structural", "Geometry") { }
    
    public override Guid ComponentGuid => new Guid("f85b9d32-e383-56a2-e6fa-1da0d28febe9");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Geometry.Restraint.ctor(Objects.Structural.Geometry.RestraintType)","Objects.Structural.Geometry.Restraint");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Result1DSchemaComponent: CreateSchemaObjectBase {
     
    public Result1DSchemaComponent(): base("Result1D (load case)", "Result1D (load case)", "Creates a Speckle 1D element result object (for load case)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("62b6e9c3-13b6-9dbd-b222-a0b6a978750e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.Result1D.ctor(Objects.Structural.Geometry.Element1D,Objects.Structural.Loading.LoadCase,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.Result1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Result1D1SchemaComponent: CreateSchemaObjectBase {
     
    public Result1D1SchemaComponent(): base("Result1D (load combination)", "Result1D (load combination)", "Creates a Speckle 1D element result object (for load combination)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("1151871b-42cc-e3f5-5e08-454f9733ef08");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.Result1D.ctor(Objects.Structural.Geometry.Element1D,Objects.Structural.Loading.LoadCombination,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.Result1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Result2DSchemaComponent: CreateSchemaObjectBase {
     
    public Result2DSchemaComponent(): base("Result2D (load case)", "Result2D (load case)", "Creates a Speckle 2D element result object (for load case)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("4d551fc5-fc7b-b2b8-5bba-63e48aeee645");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.Result2D.ctor(Objects.Structural.Geometry.Element2D,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[System.Double],System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.Result2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Result2D1SchemaComponent: CreateSchemaObjectBase {
     
    public Result2D1SchemaComponent(): base("Result2D (load combination)", "Result2D (load combination)", "Creates a Speckle 2D element result object (for load combination)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("29194017-21da-96ee-56c4-273cc84ff951");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.Result2D.ctor(Objects.Structural.Geometry.Element2D,Objects.Structural.Loading.LoadCombination,System.Collections.Generic.List`1[System.Double],System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.Result2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Result3DSchemaComponent: CreateSchemaObjectBase {
     
    public Result3DSchemaComponent(): base("Result3D (load case)", "Result3D (load case)", "Creates a Speckle 3D element result object (for load case)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("3a15c6fa-36cd-1da9-e410-928a62b940a8");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.Result3D.ctor(Objects.Structural.Geometry.Element3D,Objects.Structural.Loading.LoadCase,System.Collections.Generic.List`1[System.Double],System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.Result3D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Result3D1SchemaComponent: CreateSchemaObjectBase {
     
    public Result3D1SchemaComponent(): base("Result3D (load combination)", "Result3D (load combination)", "Creates a Speckle 3D element result object (for load combination)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("1aa4dd1e-d845-7760-0e58-a3744255f0a1");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.Result3D.ctor(Objects.Structural.Geometry.Element3D,Objects.Structural.Loading.LoadCombination,System.Collections.Generic.List`1[System.Double],System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.Result3D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultGlobalSchemaComponent: CreateSchemaObjectBase {
     
    public ResultGlobalSchemaComponent(): base("ResultGlobal (load case)", "ResultGlobal (load case)", "Creates a Speckle global result object (for load case)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("6e742681-a159-d811-8d7c-4ac42682872f");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultGlobal.ctor(Objects.Structural.Loading.LoadCase,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.ResultGlobal");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultGlobal1SchemaComponent: CreateSchemaObjectBase {
     
    public ResultGlobal1SchemaComponent(): base("ResultGlobal (load combination)", "ResultGlobal (load combination)", "Creates a Speckle global result object (for load combination)", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("cd0af8ae-e8d9-b1d9-fce1-63d137a8f69c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultGlobal.ctor(Objects.Structural.Loading.LoadCombination,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.ResultGlobal");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultNodeSchemaComponent: CreateSchemaObjectBase {
     
    public ResultNodeSchemaComponent(): base("ResultNode (load case)", "ResultNode (load case)", "Creates a Speckle structural nodal result object", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("5bf05a45-f397-00ae-0cf5-d89191042d21");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultNode.ctor(Objects.Structural.Loading.LoadCase,Objects.Structural.Geometry.Node,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.ResultNode");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultNode1SchemaComponent: CreateSchemaObjectBase {
     
    public ResultNode1SchemaComponent(): base("ResultNode (load combination)", "ResultNode (load combination)", "Creates a Speckle structural nodal result object", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("c219b902-4ffd-8d03-7de0-2264c8ad6030");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultNode.ctor(Objects.Structural.Loading.LoadCombination,Objects.Structural.Geometry.Node,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Results.ResultNode");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultSet1DSchemaComponent: CreateSchemaObjectBase {
     
    public ResultSet1DSchemaComponent(): base("ResultSet1D", "ResultSet1D", "Creates a Speckle 1D element result set object", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("7928905d-5fad-53c8-8d44-0eec0c5478ba");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultSet1D.ctor(System.Collections.Generic.List`1[Objects.Structural.Results.Result1D])","Objects.Structural.Results.ResultSet1D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultSet2DSchemaComponent: CreateSchemaObjectBase {
     
    public ResultSet2DSchemaComponent(): base("ResultSet2D", "ResultSet2D", "Creates a Speckle 2D element result set object", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("ff5bdc35-b72a-a0be-066f-5ad08fbb047d");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultSet2D.ctor(System.Collections.Generic.List`1[Objects.Structural.Results.Result2D])","Objects.Structural.Results.ResultSet2D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultSet3DSchemaComponent: CreateSchemaObjectBase {
     
    public ResultSet3DSchemaComponent(): base("ResultSet3D", "ResultSet3D", "Creates a Speckle 3D element result set object", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("7cde5263-7dd0-a1f7-535b-e9856769bc39");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultSet3D.ctor(System.Collections.Generic.List`1[Objects.Structural.Results.Result3D])","Objects.Structural.Results.ResultSet3D");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class ResultSetNodeSchemaComponent: CreateSchemaObjectBase {
     
    public ResultSetNodeSchemaComponent(): base("ResultSetNode", "ResultSetNode", "Creates a Speckle node result set object", "Speckle 2 Structural", "Results") { }
    
    public override Guid ComponentGuid => new Guid("07d3aa5f-55e8-f0c6-96da-d9599a8da233");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Results.ResultSetNode.ctor(System.Collections.Generic.List`1[Objects.Structural.Results.ResultNode])","Objects.Structural.Results.ResultSetNode");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitBeamSchemaComponent: CreateSchemaObjectBase {
     
    public RevitBeamSchemaComponent(): base("RevitBeam", "RevitBeam", "Creates a Revit beam by curve and base level.", "Speckle 2 Revit", "Structure") { }
    
    public override Guid ComponentGuid => new Guid("6aba19f5-1b1c-8e0c-f063-2a7c91816b1c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitBeam.ctor(System.String,System.String,Objects.ICurve,Objects.BuiltElements.Level,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitBeam");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitBraceSchemaComponent: CreateSchemaObjectBase {
     
    public RevitBraceSchemaComponent(): base("RevitBrace", "RevitBrace", "Creates a Revit brace by curve and base level.", "Speckle 2 Revit", "Structure") { }
    
    public override Guid ComponentGuid => new Guid("a3a689dc-2ca5-d5be-a225-99a144768e7e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitBrace.ctor(System.String,System.String,Objects.ICurve,Objects.BuiltElements.Level,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitBrace");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitCeilingSchemaComponent: CreateSchemaObjectBase {
     
    public RevitCeilingSchemaComponent(): base("RevitCeiling", "RevitCeiling", "Creates a Revit ceiling", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("93e6568e-0dc2-ebd2-64b0-e202eabe49cb");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitCeiling.ctor(Objects.ICurve,System.String,System.String,Objects.BuiltElements.Level,System.Double,Objects.Geometry.Line,System.Double,System.Collections.Generic.List`1[Objects.ICurve],System.Collections.Generic.List`1[Speckle.Core.Models.Base])","Objects.BuiltElements.Revit.RevitCeiling");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitColumnSchemaComponent: CreateSchemaObjectBase {
     
    public RevitColumnSchemaComponent(): base("RevitColumn Vertical", "RevitColumn Vertical", "Creates a vertical Revit Column by point and levels.", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("c243fe91-0103-bea1-34b7-3e8b39c8d0ec");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitColumn.ctor(System.String,System.String,Objects.ICurve,Objects.BuiltElements.Level,Objects.BuiltElements.Level,System.Double,System.Double,System.Boolean,System.Double,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitColumn");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitColumn1SchemaComponent: CreateSchemaObjectBase {
     
    public RevitColumn1SchemaComponent(): base("RevitColumn Slanted", "RevitColumn Slanted", "Creates a slanted Revit Column by curve.", "Speckle 2 Revit", "Structure") { }
    
    public override Guid ComponentGuid => new Guid("bd9936e6-c75f-c0de-feb0-b801eff0e0ea");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitColumn.ctor(System.String,System.String,Objects.ICurve,Objects.BuiltElements.Level,System.Boolean,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitColumn");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitDuctSchemaComponent: CreateSchemaObjectBase {
     
    public RevitDuctSchemaComponent(): base("RevitDuct", "RevitDuct", "Creates a Revit duct", "Speckle 2 Revit", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("d7781536-e8a9-8aef-1b27-571584f8c4a3");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitDuct.ctor(System.String,System.String,Objects.Geometry.Line,System.String,System.String,Objects.BuiltElements.Level,System.Double,System.Double,System.Double,System.Double,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitDuct");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitExtrusionRoofSchemaComponent: CreateSchemaObjectBase {
     
    public RevitExtrusionRoofSchemaComponent(): base("RevitExtrusionRoof", "RevitExtrusionRoof", "Creates a Revit roof by extruding a curve", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("707428ab-15b4-e7ec-a2cd-21154ff50c1b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitRoof.RevitExtrusionRoof.ctor(System.String,System.String,System.Double,System.Double,Objects.Geometry.Line,Objects.BuiltElements.Level,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitRoof.RevitExtrusionRoof");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitFaceWallSchemaComponent: CreateSchemaObjectBase {
     
    public RevitFaceWallSchemaComponent(): base("RevitWall by face", "RevitWall by face", "Creates a Revit wall from a surface.", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("fc3927a7-0877-8137-a34e-ecd19a6f688c");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitFaceWall.ctor(System.String,System.String,Objects.Geometry.Brep,Objects.BuiltElements.Level,Objects.BuiltElements.Revit.LocationLine,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitFaceWall");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitFloorSchemaComponent: CreateSchemaObjectBase {
     
    public RevitFloorSchemaComponent(): base("RevitFloor", "RevitFloor", "Creates a Revit floor by outline and level", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("e6f17d4f-6c28-0d0f-2370-7b9c09a14fff");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitFloor.ctor(System.String,System.String,Objects.ICurve,Objects.BuiltElements.Level,System.Boolean,System.Double,Objects.Geometry.Line,System.Collections.Generic.List`1[Objects.ICurve],System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitFloor");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitFootprintRoofSchemaComponent: CreateSchemaObjectBase {
     
    public RevitFootprintRoofSchemaComponent(): base("RevitFootprintRoof", "RevitFootprintRoof", "Creates a Revit roof by outline", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("b2f55d9f-7242-ee7e-c44a-24e34d5f6e3e");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitRoof.RevitFootprintRoof.ctor(Objects.ICurve,System.String,System.String,Objects.BuiltElements.Level,Objects.BuiltElements.Revit.RevitLevel,System.Double,System.Collections.Generic.List`1[Objects.ICurve],System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitRoof.RevitFootprintRoof");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitLevelSchemaComponent: CreateSchemaObjectBase {
     
    public RevitLevelSchemaComponent(): base("RevitLevel", "RevitLevel", "Creates a new Revit level unless one with the same elevation already exists", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("5ef6e45c-00bd-f3b9-1cbf-6e9a902da7ab");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitLevel.ctor(System.String,System.Double,System.Boolean,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitLevel");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitLevel1SchemaComponent: CreateSchemaObjectBase {
     
    public RevitLevel1SchemaComponent(): base("RevitLevel by name", "RevitLevel by name", "Gets an existing Revit level by name", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("e075a88e-7867-3726-3bb7-15b73b2d17e6");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitLevel.ctor(System.String)","Objects.BuiltElements.Revit.RevitLevel");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitPipeSchemaComponent: CreateSchemaObjectBase {
     
    public RevitPipeSchemaComponent(): base("RevitPipe", "RevitPipe", "Creates a Revit pipe", "Speckle 2 Revit", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("19700cd2-6310-c8b3-7ad5-954033702e52");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitPipe.ctor(System.String,System.String,Objects.ICurve,System.Double,Objects.BuiltElements.Level,System.String,System.String,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitPipe");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitProfileWallSchemaComponent: CreateSchemaObjectBase {
     
    public RevitProfileWallSchemaComponent(): base("RevitWall by profile", "RevitWall by profile", "Creates a Revit wall from a profile.", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("b3962fc0-69b0-e766-22b4-b08404650c8a");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitProfileWall.ctor(System.String,System.String,Objects.Geometry.Polycurve,Objects.BuiltElements.Level,Objects.BuiltElements.Revit.LocationLine,System.Boolean,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitProfileWall");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitRailingSchemaComponent: CreateSchemaObjectBase {
     
    public RevitRailingSchemaComponent(): base("Railing", "Railing", "Creates a Revit railing by base curve.", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("a6c3be7a-9e6b-663b-2bc0-dd9fa2ee6552");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitRailing.ctor(System.String,Objects.Geometry.Polycurve,Objects.BuiltElements.Level,System.Boolean)","Objects.BuiltElements.Revit.RevitRailing");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitShaftSchemaComponent: CreateSchemaObjectBase {
     
    public RevitShaftSchemaComponent(): base("RevitShaft", "RevitShaft", "Creates a Revit shaft from a bottom and top level", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("00cdb2fd-ef75-107e-822c-3490cd359380");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitShaft.ctor(Objects.ICurve,Objects.BuiltElements.Level,Objects.BuiltElements.Level,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitShaft");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitTopographySchemaComponent: CreateSchemaObjectBase {
     
    public RevitTopographySchemaComponent(): base("RevitTopography", "RevitTopography", "Creates a Revit topography", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("f0840908-039e-b6d4-98de-8ed003dfd357");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitTopography.ctor(Objects.Geometry.Mesh,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitTopography");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitWallSchemaComponent: CreateSchemaObjectBase {
     
    public RevitWallSchemaComponent(): base("RevitWall by curve and levels", "RevitWall by curve and levels", "Creates a Revit wall with a top and base level.", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("fa1aef22-ddd5-01f4-887e-145ce21da247");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitWall.ctor(System.String,System.String,Objects.ICurve,Objects.BuiltElements.Level,Objects.BuiltElements.Level,System.Double,System.Double,System.Boolean,System.Boolean,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitWall");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitWall1SchemaComponent: CreateSchemaObjectBase {
     
    public RevitWall1SchemaComponent(): base("RevitWall by curve and height", "RevitWall by curve and height", "Creates an unconnected Revit wall.", "Speckle 2 Revit", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("bd2a0bb1-14f7-cd0a-76c4-2429412a5128");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitWall.ctor(System.String,System.String,Objects.ICurve,Objects.BuiltElements.Level,System.Double,System.Double,System.Double,System.Boolean,System.Boolean,System.Collections.Generic.List`1[Speckle.Core.Models.Base],System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitWall");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RevitWireSchemaComponent: CreateSchemaObjectBase {
     
    public RevitWireSchemaComponent(): base("RevitWire", "RevitWire", "Creates a Revit wire from points and level", "Speckle 2 Revit", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("4045436b-0804-f0e1-a9f2-6217f4d8a45b");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.RevitWire.ctor(System.Collections.Generic.List`1[System.Double],System.String,System.String,Objects.BuiltElements.Level,System.String,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.RevitWire");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RoofSchemaComponent: CreateSchemaObjectBase {
     
    public RoofSchemaComponent(): base("Roof", "Roof", "Creates a Speckle roof", "Speckle 2 BIM", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("c10c6dcd-e6a8-be88-32f3-45c935d0bae9");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Roof.ctor(Objects.ICurve,System.Collections.Generic.List`1[Objects.ICurve],System.Collections.Generic.List`1[Speckle.Core.Models.Base])","Objects.BuiltElements.Roof");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RoomSchemaComponent: CreateSchemaObjectBase {
     
    public RoomSchemaComponent(): base("Room", "Room", "Creates a Speckle room", "Speckle 2 BIM", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("c62087b7-2a9d-743d-336d-e8ea2ab72a29");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Room.ctor(System.String,System.String,Objects.BuiltElements.Level,Objects.Geometry.Point)","Objects.BuiltElements.Room");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class RoomBoundaryLineSchemaComponent: CreateSchemaObjectBase {
     
    public RoomBoundaryLineSchemaComponent(): base("RoomBoundaryLine", "RoomBoundaryLine", "Creates a Revit room boundary line", "Speckle 2 Revit", "Curves") { }
    
    public override Guid ComponentGuid => new Guid("2edade8a-5139-09be-4273-551f3ac476e2");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.Curve.RoomBoundaryLine.ctor(Objects.ICurve,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.Curve.RoomBoundaryLine");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class SpaceSchemaComponent: CreateSchemaObjectBase {
     
    public SpaceSchemaComponent(): base("Space", "Space", "Creates a Speckle space", "Speckle 2 BIM", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("c6907933-2792-eb6d-7c64-fb54835e9b44");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Space.ctor(System.String,System.String,Objects.Geometry.Point,Objects.BuiltElements.Level)","Objects.BuiltElements.Space");
    }
}

// This is generated code:
public class SteelSchemaComponent: CreateSchemaObjectBase {
     
    public SteelSchemaComponent(): base("Steel", "Steel", "Creates a Speckle structural material for steel (to be used in structural analysis models)", "Speckle 2 Structural", "Materials") { }
    
    public override Guid ComponentGuid => new Guid("6756df31-1e5c-0c80-2047-f4b6557c2e3f");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Materials.Steel.ctor(System.String,System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Materials.Steel");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class Space1SchemaComponent: CreateSchemaObjectBase {
     
    public Space1SchemaComponent(): base("Space with top level and offset parameters", "Space with top level and offset parameters", "Creates a Speckle space with the specified top level and offsets", "Speckle 2 BIM", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("8f7b0323-3533-e7cd-ae43-0bdeb34f3570");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Space.ctor(System.String,System.String,Objects.Geometry.Point,Objects.BuiltElements.Level,Objects.BuiltElements.Level,System.Double,System.Double)","Objects.BuiltElements.Space");
    }
}

// This is generated code:
public class TaskSchemaComponent: CreateSchemaObjectBase {
     
    public TaskSchemaComponent(): base("AnalysisTask", "AnalysisTask", "Creates a Speckle structural analysis task for GSA", "Speckle 2 GSA", "Analysis") { }
    
    public override Guid ComponentGuid => new Guid("2c7bcf2b-eb50-b74e-fdf3-4f0de9cbae92");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.GSA.Analysis.Task.ctor(System.Int32,System.String)","Objects.Structural.GSA.Analysis.Task");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class SpaceSeparationLineSchemaComponent: CreateSchemaObjectBase {
     
    public SpaceSeparationLineSchemaComponent(): base("SpaceSeparationLine", "SpaceSeparationLine", "Creates a Revit space separation line", "Speckle 2 Revit", "Curves") { }
    
    public override Guid ComponentGuid => new Guid("0bba13ce-5758-8513-42fd-9e0b3702a654");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Revit.Curve.SpaceSeparationLine.ctor(Objects.ICurve,System.Collections.Generic.List`1[Objects.BuiltElements.Revit.Parameter])","Objects.BuiltElements.Revit.Curve.SpaceSeparationLine");
    }
}

// This is generated code:
public class TeeSchemaComponent: CreateSchemaObjectBase {
     
    public TeeSchemaComponent(): base("Tee", "Tee", "Creates a Speckle structural Tee section profile", "Speckle 2 Structural", "Section Profile") { }
    
    public override Guid ComponentGuid => new Guid("7832cac3-92e9-9083-df97-0d4296b457c3");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Properties.Profiles.SectionProfile+Tee.ctor(System.String,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Properties.Profiles.SectionProfile+Tee");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class TimberSchemaComponent: CreateSchemaObjectBase {
     
    public TimberSchemaComponent(): base("Timber", "Timber", "Creates a Speckle structural material for timber (to be used in structural analysis models)", "Speckle 2 Structural", "Materials") { }
    
    public override Guid ComponentGuid => new Guid("f11d278f-6a36-fd7c-409d-fb39f52c73f5");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.Structural.Materials.Timber.ctor(System.String,System.String,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)","Objects.Structural.Materials.Timber");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class TopographySchemaComponent: CreateSchemaObjectBase {
     
    public TopographySchemaComponent(): base("Topography", "Topography", "Creates a Speckle topography", "Speckle 2 BIM", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("b9207a45-eebc-72d6-a411-f496443d8b7f");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Topography.ctor(Objects.Geometry.Mesh)","Objects.BuiltElements.Topography");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class WallSchemaComponent: CreateSchemaObjectBase {
     
    public WallSchemaComponent(): base("Wall", "Wall", "Creates a Speckle wall", "Speckle 2 BIM", "Architecture") { }
    
    public override Guid ComponentGuid => new Guid("6878cc65-2628-d00d-e8c0-b130e828a6c7");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Wall.ctor(System.Double,Objects.ICurve,System.Collections.Generic.List`1[Speckle.Core.Models.Base])","Objects.BuiltElements.Wall");
        base.AddedToDocument(document);
    }
}

// This is generated code:
public class WireSchemaComponent: CreateSchemaObjectBase {
     
    public WireSchemaComponent(): base("Wire", "Wire", "Creates a Speckle wire from curve segments and points", "Speckle 2 BIM", "MEP") { }
    
    public override Guid ComponentGuid => new Guid("c10c9c87-b93d-4e98-d2fb-942d182008dc");
    
    public override void AddedToDocument(GH_Document document){
        SelectedConstructor = CSOUtils.FindConstructor("Objects.BuiltElements.Wire.ctor(System.Collections.Generic.List`1[Objects.ICurve])","Objects.BuiltElements.Wire");
        base.AddedToDocument(document);
    }
}


}
