using System;
using System.Collections.Generic;
using CodeEstimator.SpecialLineCounters;

namespace CodeEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = args[0];
            LineCounter linesCounter = new LineCounter();
            var result = linesCounter.CountLines(System.IO.File.ReadLines(filePath));

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
