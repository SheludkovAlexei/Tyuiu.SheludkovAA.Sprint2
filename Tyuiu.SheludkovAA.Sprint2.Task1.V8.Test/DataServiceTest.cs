using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint2.Task1.V8.Lib;


namespace Tyuiu.SheludkovAA.Sprint2.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 1;
            int b = 4;
            int c = 3;
            int d = 10;
            bool[] wait = new bool[6] { true, false, true, false, false, false };
            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
            
        }
    }
}
