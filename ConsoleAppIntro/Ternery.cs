using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIntro
{
    internal class Ternery
    {
        static void Main()
        {
            int a, b,c;
            Console.WriteLine("enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            c = a > b ? a : b;
            Console.WriteLine($"The biggest number is {c}");
        }
    }
}
// biggest between 3 nos