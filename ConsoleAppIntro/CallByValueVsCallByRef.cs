using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIntro
{
    internal class CallByValueVsCallByRef
    {
        /*
         Argument - data which we pass to function
         Actual Argument ( has calling function)
         Formal Argument ( has called function)
         
         
         */
        static void Main() // main is a calling function
        {
            int x = 10;
            Console.WriteLine($"Before call of cbv value of X={x}");
            cbv(x); // here x is an actual argument
            Console.WriteLine($"After call of cbv value of X={x}");

            cbr(ref x);

            Console.WriteLine($"After call of CBR value of X={x}");


        }
        static void cbv(int y) // here y is an formal argument
        {
            y = 100;
        }
        // in call by value if any change in formal argument it does not affect actual argument
        static void cbr(ref int y) // here y is an formal argument
        {
            y = 100;
        }
        // in call by reference if any change in formal argument it affects actual argument
        static void swap(ref int x, ref int y)
        {
            int temp=x; x=y; y=temp;        
        }
    }
}
