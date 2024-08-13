using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double numOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            double result = numOne + numTwo;

            Console.WriteLine("Вот результат сложения двух чисел: " + result);

            Console.ReadKey();
        }
    }
}
