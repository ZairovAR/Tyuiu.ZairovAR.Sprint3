using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint3.Task0.V26.Lib;
namespace Tyuiu.ZairovAR.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1; 
            int stopValue = 9;
            double res = ds.GetMultiplySeries(startValue, stopValue) ;

            double wait = -26.731;

            Assert.AreEqual(res, wait);
        }
    }
}
