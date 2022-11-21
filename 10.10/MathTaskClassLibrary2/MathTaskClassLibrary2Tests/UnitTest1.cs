using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void СylinderVolume_return()
        {
            
            int S = 3;
            int h = 5;
            int V = 15;

            
            Geometry g = new Geometry();
            int actual = g.СylinderVolume(S, h);

            
            Assert.AreEqual(V, actual);
        }
    }
}
