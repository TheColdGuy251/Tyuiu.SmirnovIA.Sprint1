using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.SmirnovIA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.00;
            double y = 2.00;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4.871, res);
        }
    }
}
