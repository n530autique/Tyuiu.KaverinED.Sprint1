using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint1.Task7.V11.Lib;
namespace Tyuiu.KaverinED.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 0);
            Assert.AreEqual(-1.249, res);
        }
    }
}
