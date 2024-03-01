using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SafronovSV.Sprint3.Task4.V11.Lib;
namespace Tyuiu.SafronovSV.Sprint3.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int starValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(starValue, stopValue);
            double wait = -0.917;
            Assert.AreEqual(res, -0.917);
            
        }
    }
}
