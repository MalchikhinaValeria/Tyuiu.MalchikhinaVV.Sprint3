using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint3.Task3.V24.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint3.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';


            string res = ds.ReplaceCharInString(value, replaceable, replacement);
            string wait = "*ft h**t nt*";
            Assert.AreEqual(wait, res);
        }
    }
}
