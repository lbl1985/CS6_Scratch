using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee
    {
        public int YearsOfServices { get; set; }
        public int Office { get; set; }
        public Employee(int years, int office)
        {
            YearsOfServices = years;
            Office = office;
        }

        public Employee()
        {

        }
    }
}
