using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delossnatos
{
    internal class Program


    {
        static void Main(string[] args)
        {
            double key = 5;
            double door = 2;
            double powerResult = Math.Pow(key, door);
            Console.WriteLine($"{key} To the power of {door} is {powerResult}");

            double cookies = 10;
            double exponentResult = Math.Exp(cookies);
            Console.WriteLine($"The exponential of {cookies} is {exponentResult}");

            double number = 3;
            double pizza = 9;
            double logResult = Math.Log(number, pizza);
            Console.WriteLine($"The logarithm of {number} with base {pizza} is {logResult}");

            double Mitsubishi = 16;
            double sqrtResult = Math.Sqrt(Mitsubishi);
            Console.WriteLine($"The square root of {Mitsubishi} is {sqrtResult}");

            double celling = 3.7;
            double ceilingResult = Math.Ceiling(celling);
            Console.WriteLine($"The ceiling of {celling} is {ceilingResult}");

            



            Console.ReadKey();


        }
    }
}
