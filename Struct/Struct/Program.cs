using System;
using Staticclass;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");

            string option = Console.ReadLine();
            decimal F, C = 0;

            switch (option)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    F = Practicingstatic.CelsiusToFahrenhet(Console.ReadLine());
                    Console.WriteLine("Fahrenheit:{0:F2}", F);
                    break;

                case "2":
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    F = Practicingstatic.FahrenheatToCelsisu(Console.ReadLine());
                    Console.WriteLine("Celsius: {0:F2}", C);
                    break;
            }
        }
    }
}
