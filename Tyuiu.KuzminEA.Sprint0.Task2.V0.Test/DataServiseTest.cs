using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KuzminEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KuzminEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {

            var name = "Егор";
            var res = DataServise.GetMassage(name);
        }
    }
}
