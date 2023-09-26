using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint1.Task6.V7.Lib; 
namespace Tyuiu.KaverinED.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string a = "ya egor mne ten";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(a);
            Assert.AreEqual(res, "y ego mn te");
        }
    }
}
