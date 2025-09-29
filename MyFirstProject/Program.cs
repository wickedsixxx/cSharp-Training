using System;

namespace MyFirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int angleCount = 3;
            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.WriteLine($"enter angle {i + 1}: ");
                angleSum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(angleSum == 180 ? "valid" : "invalid");

            Console.ReadLine();

        }
    }
}
