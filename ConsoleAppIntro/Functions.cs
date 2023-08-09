//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppIntro
//{
//    internal class Functions
//    {
//        /*
        
//        Function is a set of instructions under a name. It always ready to perform job you just call it.
//        Sometime function accept arguments(data) we need to pass that data to function during call
//       */
//        static void Main()
//        {
//            Console.WriteLine("Hello User");
           
//            msg(); // calling of msg function
            
//            table(7); // 7 is an argument (data which we pass to function)

//           int r= fact(5);
           
//           Console.WriteLine($"The factorial is {r}");

//        }
//        static void msg() // msg is a function it does not accept and does not return
//        {
//            Console.WriteLine("Welcome to msg function");
//        }
//        static void table(int num) // table is a function that does not return and accept an int value
//        {
//            int i;
//            for(i=1;i<=10;i++)
//            {

//                Console.WriteLine($"{num}x{i}={num*i}");
//            }
//        }

//        static int fact(int num) // fact is a function it accept an int value and return also an int value
//        {
//            int i, f = 1;
//            for (i = 1; i <= num; i++)
//            {
//                f = f * i;
//            }
//            return f;
//        }
//    }
//}
