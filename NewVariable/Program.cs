using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 31;
            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Binlong Li";

            Console.WriteLine($"myAge: {myAge}, x:{x}, myHourlyRate:{myHourlyRate}, myName:{myName}");

            myAge = 35;
            x = 20;
            myHourlyRate = 85;
            myName = "George Washington";
            Console.WriteLine($"myAge: {myAge}, x:{x}, myHourlyRate:{myHourlyRate}, myName:{myName}");
        }
    }
}
