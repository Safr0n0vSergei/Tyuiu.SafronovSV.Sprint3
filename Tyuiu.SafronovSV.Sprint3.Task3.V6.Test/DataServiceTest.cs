using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SafronovSV.Sprint3.Task3.V6.Lib;
namespace Tyuiu.SafronovSV.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "12able 1o s4gh";
            char item = 't';
            string res = ds.ReplaceNumOnChar(value, item);
            string wait = "ttable to stgh";
            Assert.AreEqual(wait, res);
        }
    }
}
