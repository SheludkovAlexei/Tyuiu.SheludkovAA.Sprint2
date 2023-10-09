using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint2.Task0.V10.Lib;

namespace Tyuiu.SheludkovAA.Sprint2.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int x = 2;
            int y = 1;
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
