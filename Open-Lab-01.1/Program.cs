using System;
using System.IO;

namespace Open_Lab_01._1
{
    class GFG
    {
        public static void Main()
        {
            int number;

            Console.WriteLine("Enter your number: ");

            number = Convert.ToInt32(Console.ReadLine());

            {
                if (number < 10)
                    Console.WriteLine("The number is less than 10.");
                else
                    Console.WriteLine("This number is greater or equal to 10.");

            }
        }
    }
}
