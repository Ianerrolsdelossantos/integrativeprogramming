using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delossantos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] classmates = { "Anna", "Brian", "Carla", "David", "Ella", "Frank" };

            Console.WriteLine("Classmates:");
            foreach (string name in classmates)
            {
                Console.WriteLine(name);
            }

            
            char[,] letters =
            {
                { 'A', 'B', 'C' },
                { 'D', 'E', 'F' }
            };

            Console.WriteLine("\nTwo-Dimensional Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(letters[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            string message = "Hello everyone, welcome to the class!";

            if (message.ToLower().Contains("hello"))
            {
                Console.WriteLine("\nThe message contains the word 'hello'.");
            }
            else
            {
                Console.WriteLine("\nThe message does not contain the word 'hello'.");
            }
        }
    }
}
        
    

