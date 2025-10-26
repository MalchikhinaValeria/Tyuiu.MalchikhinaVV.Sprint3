using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint3.Task2.V26.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint3.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 411589.537;

            Assert.AreEqual(wait, res);
        }
    }
}
