using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Tyuiu.ZairovAR.Sprint3.Task5.V3.Lib;
namespace Tyuiu.ZairovAR.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1; 
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 33.247;

            Assert.AreEqual(res, wait);

        }
    }
}
