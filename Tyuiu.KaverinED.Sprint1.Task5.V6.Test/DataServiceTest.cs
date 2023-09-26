using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint1.Task5.V6.Lib;
namespace Tyuiu.KaverinED.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 12;
            DataService ds = new DataService();
            int res = ds.Calculate(k);
            Assert.AreEqual(res, 5);
        }
    }
}
