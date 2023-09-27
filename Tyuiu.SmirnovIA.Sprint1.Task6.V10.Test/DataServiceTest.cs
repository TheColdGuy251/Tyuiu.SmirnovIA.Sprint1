using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.SmirnovIA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Вот тебе слова, переделывай";
            var res = ds.DeleteMiddleLetter(value);
            Assert.AreEqual("Вт тебе слова, передлывай", res);
        }
    }
}
