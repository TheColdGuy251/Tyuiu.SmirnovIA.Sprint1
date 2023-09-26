using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.SmirnovIA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int time = 13257;
            var res = ds.SecondsToHours(time);
            Assert.AreEqual(3, res);
        }
    }
}
