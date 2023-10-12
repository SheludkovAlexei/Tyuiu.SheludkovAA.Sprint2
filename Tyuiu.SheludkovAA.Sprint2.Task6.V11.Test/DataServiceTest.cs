using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.SheludkovAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1999;
            int y = 12;
            int z = 31;
            string wait = "1 Января 2000 год";
            var res = ds.FindDateOfNextDay(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}
