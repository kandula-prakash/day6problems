using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_series
{
    class Class2
    {
        public static void stopwatch()
        {
            double start, stop;
            Console.WriteLine("enter starting time of stopwatch in 24 hours format:");
            start=double.Parse(Console.ReadLine());
            Console.WriteLine("enter ending time of stopwatch in 24 hours format:");
            stop = double.Parse(Console.ReadLine());

            double elapsedHour = stop - start;

            double startmin, stopmin;
            startmin= start *60;
            stopmin = stop * 60;
            double elapsedMin = stopmin - startmin;

            double startsec, stopsec;
            startsec = start * 60;
            stopsec = stop * 60;
            double elapesdSec = stopsec - startsec;

            double startMsec, stopMsec;
            startMsec = start * 60 * 1000;
            stopMsec = stop * 60 * 1000;
            double elapesdMsec = stopMsec - startMsec;
            Console.WriteLine("the elapsed time in hour :minutes:seconds:miliseconds formate is:" +elapsedHour+":"+elapsedMin+":"+elapesdSec+":"+elapesdMsec+":");

        }
    }
}
