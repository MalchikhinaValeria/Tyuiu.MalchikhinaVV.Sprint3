using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint3.Task0.V8.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint3.Task0.V8.Test
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
            int stopValue = 10;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = -0.886;

            Assert.AreEqual(wait, res);
        }
    }
}
