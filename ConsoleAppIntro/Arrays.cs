//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppIntro
//{
//    internal class Arrays
//    {
//        static void Main()
//        {
//            // collection of multiple values of same type
//            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//            //for(int i = 0; i < a.Length; i++)
//            //{
//            //    Console.WriteLine(a[i]);
//            //}

//            int[] b=new int[5];
//            int i,sum=0;
//            for(i=0;i<5;i++)
//            {
//                Console.WriteLine("Enter element:");
//                b[i]=Convert.ToInt32(Console.ReadLine());   
//            }
//            Console.WriteLine("\nYour array elements are:");
//            for (i = 0; i < 5; i++)
//            {
//                sum = sum + b[i];
//                Console.WriteLine(b[i]);
//            }
//            Console.WriteLine($"The sum of array elements is {sum}");
//            Console.WriteLine("Array in reverse order");
//            for(i = 4; i >=0;i--)
//            {
//                Console.WriteLine(b[i]);
//            }
//            /*
//             1. Search and element
//             2. Print Biggest element
//             3. sort array elements
//             */

//        }
//    }
//}
