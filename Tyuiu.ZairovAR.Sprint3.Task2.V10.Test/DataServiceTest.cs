﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint3.Task2.V10.Lib;
namespace Tyuiu.ZairovAR.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService() ;
            int value = 1;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 15.252;
            Assert.AreEqual(wait, res);
        }
    }
}
