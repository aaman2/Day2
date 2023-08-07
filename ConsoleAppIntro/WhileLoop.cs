//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppIntro
//{
//    internal class WhileLoop
//    {
//        static void Main()
//        {
//            // input a number and count its digits
//            /*
//                while(condition)
//                {
//                    .....
//                }
             
//             */
//            int num, x = 0, y=0, z=0, temp ;
//            Console.WriteLine("enter a number");
//            num = Convert.ToInt32(Console.ReadLine()); // 512
//            temp = num; 
//            while(num > 0) // 512>0=>true, 51>0=>true, 5>0, 0>0 
//            {
//                x = x + 1; // 1, 2, 3
//                y = y + num % 10;
//                z = z * 10 + num % 10;
//                num = num / 10; // num=512/10=>51, num=51/10=>5, num=5/10=>0 

//            } //--------------------------------------------->
//            Console.WriteLine($"The digits of {temp} is {x}");
//            Console.WriteLine($"The sum of digits of {temp} is {y}");
//            Console.WriteLine($"The reverse of digits of {temp} is {z}");
//            /*
//             enter a number and print it in word => 512 Five One Two Only.
             
//             */
//        }
//    }
//}
