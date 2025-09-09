using System;
using System.Threading;

namespace MyFirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("enter a number for the FizzBuzz Game sir: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else { Console.WriteLine(i); }
            }

            Console.ReadLine();

        }
    }
}