using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_grades
{
    internal class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Enter 5 Grade separate by new line");
            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());
            double grade5 = Convert.ToDouble(Console.ReadLine());

              double total = grade1 + grade2 + grade3 + grade4 + grade5;
            double average = total / 5;
            int roundedAverage = (int)Math.Round(average);
            Console.WriteLine($"Average: {average} round off to {roundedAverage}");



        }
    }
}
