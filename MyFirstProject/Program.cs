using System;

namespace MyFirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Enter the password: ");

            string userPassword = Console.ReadLine();

            Console.WriteLine("Enter the password again: ");

            string password = Console.ReadLine();



           if (string.IsNullOrEmpty(userPassword) && string.IsNullOrEmpty(password) ) //veya if (userPassword == "" && password == "")
            {
                Console.WriteLine("Enter password pls");
            }

            else if (userPassword == password)
            {
                Console.WriteLine("correct password");
            }

            else if (userPassword != password)
            {
                Console.WriteLine("passwords do not match");
            }
            Console.ReadLine();

        }
    }
}
