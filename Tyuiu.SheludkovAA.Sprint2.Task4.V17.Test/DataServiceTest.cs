using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint2.Task4.V17.Lib;

namespace Tyuiu.SheludkovAA.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 24;
            double y = 1;
            double wait = 6.003;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 24;
            double y = 4;
            double wait = 4.021;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
