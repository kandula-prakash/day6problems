using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_series
{
    class problem3
    {
       public static void primenumber()
        {
            int number;
            int count = 0;
            Console.WriteLine("enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i= 2; i < num; i++)
            {
                if (num%i==0)
                {
                        count++;

                }

            }
            if (count==0)
            {
                Console.WriteLine("prime number");

            }
            else
            {
                Console.WriteLine("not a prime number");
            }
            Console.ReadLine();
        }
    }
}
