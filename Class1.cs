using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_series
{
    class Class1
    {
       public static void reversenumber()
        {
            int number;
            int reverse = 0;
            int rem;
            Console.WriteLine("enter the number:");
            number = Convert.ToInt32(Console.ReadLine());
            while (number!=0)
            {
                rem =number%10;
                reverse = reverse * 10 + rem;
                number /= 10;



            }
            Console.WriteLine("reversed number. "+reverse);
        }
    }
}
