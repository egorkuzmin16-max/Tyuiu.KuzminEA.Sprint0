using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KuzminEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KuzminEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            // Область создания методов тестирования , методов из библиотеки 
            var name = "Егор";
            var res = DataService.GetMassage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Егор", res);
        }
    }
}
