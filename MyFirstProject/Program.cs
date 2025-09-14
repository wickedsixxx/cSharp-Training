using System;
using System.Linq.Expressions;

namespace MyFirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int angleCount = 3;

            int[] angles = new int [angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"enter angle {i + 1 }: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum ==180 ? "valid" : "invalid");

            Console.ReadLine();

        }
    }
}
