using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint1.Task3.V18.Lib;
namespace Tyuiu.KaverinED.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
            
        {
            DataService ds = new DataService();
            double a = 4, b = 5, c = 2, res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(res, 4);
        }
    }
}
//