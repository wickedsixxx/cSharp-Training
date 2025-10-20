using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("How much numbers do you want to check? ");
            int numbersToCheck = int.Parse(Console.ReadLine());

            List<int> evenNumberList = new List<int>();
            List<int> oddNumberList = new List<int>();

            for (int i = 0; i <numbersToCheck; i++)
            {
                Console.Write("enter number to even/odd check: ");
            int numbers = int.Parse(Console.ReadLine());

                if (numbers % 2 == 0)
                {

                    evenNumberList.Add(numbers);
                }

                else
                {

                    oddNumberList.Add(numbers);
                }
            }
            Console.WriteLine("\nEven number list: ");
            foreach (int n in evenNumberList)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nOdd number list: ");
            foreach (int n in oddNumberList)
            {
                Console.WriteLine(n);
            }
        }
    }
}
