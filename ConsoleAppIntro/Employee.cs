using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIntro
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public decimal Salary { get; set; }
        public string? Department { get; set; }

        public DateTime HireDate { get; set; }

    }
}
