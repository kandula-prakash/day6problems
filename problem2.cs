using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_series
{
    class problem2
    {
       public static void perfectnumber()
        {
            int number, sum = 0, n;
            Console.WriteLine("enter the number");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i ==0)
                {
                    sum =sum+i;

                }
                if (sum == n)
                {
                    Console.WriteLine("enter perfect number");
                    Console.ReadLine();

                }

            }
        }
    }
}
