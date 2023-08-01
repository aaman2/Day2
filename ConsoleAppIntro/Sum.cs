using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIntro
{
    internal class Sum
    {
        static void Main()
        {
            int n1, n2, total;
            Console.WriteLine("enter 1st number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            n2 = Convert.ToInt32(Console.ReadLine());


            total = n1 + n2;
            Console.WriteLine($"The sum is {total}"); //$"" (string interpolation)
            Console.WriteLine($"The sum of {n1} and {n2} is {total}");

        }
    }
}
/*
 
 -
 *
 /
 % 
 
 */