using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while(selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F/ahrenheit to Celsius or Q)uit");
                selection = Console.ReadLine();
                double farenheit = 0, celsius = 0;
                //TemperatureConverter converter = new TemperatureConverter;
                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius Temperature: ");
                        farenheit = TemperatureConverter.CelsiusToFabrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {farenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit Temperature: ");                        
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}");
                        break;
                    case "q":
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
            }
        }
    }
}
