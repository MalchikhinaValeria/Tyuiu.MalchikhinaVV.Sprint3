using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint3.Task6.V26.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint3.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 15;
            int stopValue = 22;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 33;
            Assert.AreEqual(wait, res);
        }
    }
}
