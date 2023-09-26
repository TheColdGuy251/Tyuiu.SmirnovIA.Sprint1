using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using Tyuiu.SmirnovIA.Sprint1.Task4.V11.Lib;

namespace Tyuiu.SmirnovIA.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.106;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
