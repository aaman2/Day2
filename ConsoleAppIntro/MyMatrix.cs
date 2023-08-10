using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIntro
{
    internal class MyMatrix
    {
        static void Main()
        {
            int[,] a = new int[3, 3];
            int i, j;
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.WriteLine("enter element:");
                    a[i,j]=Convert.ToInt32(Console.ReadLine()); 
                }
            }
            Console.WriteLine("Your matrix elements are:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    Console.Write($"{a[i,j]}\t");  
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Your matrix transpose elements are:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    Console.Write($"{a[j, i]}\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Your matrix left diagonal elements are:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                        Console.Write($"{a[j, i]}\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Your matrix right diagonal elements are:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i +j==2)
                        Console.Write($"{a[j, i]}\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
/*
 1. lower triangle 
 2. upper triangle
 3. sum of 2 matrix
 4. product of 2 matrix
 
 */