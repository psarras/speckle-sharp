﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using Speckle.Core.Logging;
using Speckle.Core.Models;
using Tests;

namespace Tests
{
  [TestFixture]
  public class BaseTests
  {
    [Test(Description = "Checks if validation is performed in property names")]
    public void CanValidatePropNames()
    {
      dynamic @base = new Base();

      // Word chars are OK
      @base["something"] = "B";

      // Only single leading @ allowed
      @base["@something"] = "A";
      Assert.Throws<SpeckleException>(() => { @base["@@@something"] = "Testing"; });

      // Invalid chars:  ./
      Assert.Throws<SpeckleException>(() => { @base["some.thing"] = "Testing"; });
      Assert.Throws<SpeckleException>(() => { @base["some/thing"] = "Testing"; });

      // Trying to change a class member value will throw exceptions.
      //Assert.Throws<Exception>(() => { @base["speckle_type"] = "Testing"; });
      //Assert.Throws<Exception>(() => { @base["id"] = "Testing"; });
    }

    [Test]
    public void CountDynamicChunkables()
    {
      int MAX_NUM = 3000;
      var @base = new Base();
      var customChunk = new List<double>();
      var customChunkArr = new double[MAX_NUM];

      for (int i = 0; i < MAX_NUM; i++)
      {
        customChunk.Add(i / 2);
        customChunkArr[i] = i;
      }

      @base["@(1000)cc1"] = customChunk;
      @base["@(1000)cc2"] = customChunkArr;

      var num = @base.GetTotalChildrenCount();
      Assert.AreEqual(MAX_NUM / 1000 * 2 + 1, num);
    }

    [Test]
    public void CountTypedChunkables()
    {
      int MAX_NUM = 3000;
      var @base = new SampleObject();
      var customChunk = new List<double>();
      var customChunkArr = new double[MAX_NUM];

      for (int i = 0; i < MAX_NUM; i++)
      {
        customChunk.Add(i / 2);
        customChunkArr[i] = i;
      }

      @base.list = customChunk;
      @base.arr = customChunkArr;

      var num = @base.GetTotalChildrenCount();
      var actualNum = 1 + MAX_NUM / 300 + MAX_NUM / 1000;
      Assert.AreEqual(actualNum, num);
    }

    public class SampleObject : Base
    {
      [Chunkable]
      [DetachProperty]
      public List<double> list { get; set; } = new List<double>();

      [Chunkable(300)]
      [DetachProperty]
      public double[] arr { get; set; }

      [DetachProperty]
      public SampleProp detachedProp { get; set; }

      public SampleProp attachedProp { get; set; }

      public string @crazyProp { get; set; }

      public SampleObject() { }
    }

    public class SampleProp
    {
      public string name { get; set; }
    }
  }
}
