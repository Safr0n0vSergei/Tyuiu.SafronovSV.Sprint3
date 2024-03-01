using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SafronovSV.Sprint3.Task0.V13.Lib;
namespace Tyuiu.SafronovSV.Sprint3.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.298;
            Assert.AreEqual(wait, res);
        }
    }
}
