using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint3.Task1.V12.Lib;
namespace Tyuiu.ZairovAR.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            int value = 5;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.001;
            Assert.AreEqual(wait, res);
        }
    }
}
