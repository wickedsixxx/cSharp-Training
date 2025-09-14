using System;

namespace MyFirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i --)
            {
                Console.WriteLine(text[i]);
            }
            Console.ReadLine();
        }
    }
}