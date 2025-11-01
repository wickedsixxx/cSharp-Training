using System;

namespace MyFirstProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of traingle: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of traingle: ");
            int width = int.Parse(Console.ReadLine());

            int area = calculateArea(height, width);
            Console.WriteLine(area);
        }

        public static int calculateArea(int height, int width)
        {
            int area = (height * width) / 2;
            return area;

        }
    }

}


