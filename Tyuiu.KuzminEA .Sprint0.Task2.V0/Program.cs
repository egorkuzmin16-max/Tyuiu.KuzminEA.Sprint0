using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KuzminEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KuzminEA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMassage
            //из библиотеки Tyuiu.KuzminEA .Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMassage("Егор"));
            Console.ReadKey();
        }
    }
}
