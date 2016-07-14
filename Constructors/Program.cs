using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(5, 101);
            Console.WriteLine($"emp years of service: {emp.YearsOfServices.ToString()}");
            Console.WriteLine($"emp office: {emp.Office.ToString()}");

            Employee emp2 = new Employee();
            emp2.YearsOfServices = 2;
            emp2.Office = 201;
            Console.WriteLine($"emp years of service: {emp2.YearsOfServices.ToString()}");
            Console.WriteLine($"emp office: {emp2.Office.ToString()}");

            Employee emp3 = new Employee()
            {
                YearsOfServices = 20,
                Office = 301
            };
            Console.WriteLine($"emp years of service: {emp3.YearsOfServices.ToString()}");
            Console.WriteLine($"emp office: {emp3.Office.ToString()}");

        }
    }
}
