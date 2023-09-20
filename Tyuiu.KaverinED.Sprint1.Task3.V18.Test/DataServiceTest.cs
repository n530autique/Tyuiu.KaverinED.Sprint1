using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.KaverinED.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
            
        {
            int a = 4, b = 5, c = 2;
            int res = (a / c) * (b / c);
            Assert.AreEqual(res, 4);
        }
    }
}
//