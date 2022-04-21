using System;
using System.Collections.Generic;

namespace CodeEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = args[0];
            var specialLineCounters = new List<ISpecialLineCounter>() {
                new CommentLineCounter(),
                new BlankLineCounter()
            };
            LineCounter linesCounter = new LineCounter(specialLineCounters);
            var result = linesCounter.CountLines(System.IO.File.ReadLines(filePath));

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
