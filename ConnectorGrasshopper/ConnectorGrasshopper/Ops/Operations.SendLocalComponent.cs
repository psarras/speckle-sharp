﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Data;
using Grasshopper.Kernel.Types;
using GrasshopperAsyncComponent;
using Speckle.Core.Api;
using Speckle.Core.Kits;
using Speckle.Core.Logging;
using Speckle.Core.Models;
using Utilities = ConnectorGrasshopper.Extras.Utilities;

namespace ConnectorGrasshopper.Ops
{
  public class SendLocalComponent : GH_AsyncComponent
  {
    public override GH_Exposure Exposure => GH_Exposure.tertiary | GH_Exposure.obscure;

    public ISpeckleConverter Converter;

    public ISpeckleKit Kit;
    public SendLocalComponent() : base("Local sender", "LS", "Sends data locally, without the need of a Speckle Server.", ComponentCategories.SECONDARY_RIBBON, ComponentCategories.SEND_RECEIVE)
    {
      BaseWorker = new SendLocalWorker(this);
    }

    protected override Bitmap Icon => Properties.Resources.LocalSender;

    public override Guid ComponentGuid => new Guid("80AC1649-FF36-4B8B-A5B4-320E9D88F8BF");

    public override void AddedToDocument(GH_Document document)
    {
      SetDefaultKitAndConverter();
      base.AddedToDocument(document);
    }
    
    protected override void RegisterInputParams(GH_InputParamManager pManager)
    {
      pManager.AddGenericParameter("Data", "D", "Data to send.", GH_ParamAccess.tree);
    }

    protected override void RegisterOutputParams(GH_OutputParamManager pManager)
    {
      pManager.AddGenericParameter("localDataId", "id", "ID of the local data sent.", GH_ParamAccess.item);
    }

    protected override void AppendAdditionalComponentMenuItems(ToolStripDropDown menu)
    {
      Menu_AppendSeparator(menu);
      Menu_AppendItem(menu, "Select the converter you want to use:");
      var kits = KitManager.GetKitsWithConvertersForApp(Applications.Rhino6);

      foreach (var kit in kits)
      {
        Menu_AppendItem(menu, $"{kit.Name} ({kit.Description})", (s, e) => { SetConverterFromKit(kit.Name); }, true,
          kit.Name == Kit.Name);
      }

      base.AppendAdditionalComponentMenuItems(menu);
    }

    public void SetConverterFromKit(string kitName)
    {
      if (kitName == Kit.Name)return;

      Kit = KitManager.Kits.FirstOrDefault(k => k.Name == kitName);
      Converter = Kit.LoadConverter(Applications.Rhino6);

      Message = $"Using the {Kit.Name} Converter";
      ExpireSolution(true);
    }

    public bool foundKit;
    private void SetDefaultKitAndConverter()
    {
      try
      {
        Kit = KitManager.GetDefaultKit();
        Converter = Kit.LoadConverter(Applications.Rhino6);
        Converter.SetContextDocument(Rhino.RhinoDoc.ActiveDoc);
        foundKit = true;
      }
      catch
      {
        AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "No default kit found on this machine.");
        foundKit = false;
      }
    }
    
    protected override void SolveInstance(IGH_DataAccess DA)
    {
      if (!foundKit)
      {
        AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "No kit found on this machine.");
        return;
      }
      base.SolveInstance(DA);
    }
    protected override void BeforeSolveInstance()
    {
      Tracker.TrackPageview(Tracker.SEND_LOCAL);
      base.BeforeSolveInstance();
    }
  }

  public class SendLocalWorker : WorkerInstance
  {
    private GH_Structure<IGH_Goo> data;
    
    private string sentObjectId;
    public SendLocalWorker(GH_Component _parent) : base(_parent)
    { }

    public override WorkerInstance Duplicate() => new SendLocalWorker(Parent);

    public override void DoWork(Action<string, double> ReportProgress, Action Done)
    {
      Parent.Message = "Sending...";
      try
      {
        var converter = (Parent as SendLocalComponent)?.Converter;
        converter?.SetContextDocument(Rhino.RhinoDoc.ActiveDoc);
        var converted = Utilities.DataTreeToNestedLists(data, converter);
        var ObjectToSend = new Base();
        ObjectToSend["@data"] = converted;
        sentObjectId = Operations.Send(ObjectToSend, disposeTransports: true).Result;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        RuntimeMessages.Add((GH_RuntimeMessageLevel.Warning, e.Message));
      }

      Done();
    }
    
    List<(GH_RuntimeMessageLevel, string)> RuntimeMessages { get; set; } = new List<(GH_RuntimeMessageLevel, string)>();

    public override void SetData(IGH_DataAccess DA)
    {
      DA.SetData(0, sentObjectId);
      foreach (var (level, message) in RuntimeMessages)
      {
        Parent.AddRuntimeMessage(level, message);
      }
      data = null;
    }

    public override void GetData(IGH_DataAccess DA, GH_ComponentParamServer Params)
    {
      DA.GetDataTree(0, out data);
      sentObjectId = null;
    }
  }
}
