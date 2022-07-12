using System.Collections.Generic;
using CodeEstimator.SpecialLineCounters;
using Xunit;

namespace CodeEstimator.Test
{
    public class LineCounterTest
    {
        [Fact]
        public void LineCounter_CountsAllLines()
        {
            var linesCounter = new LineCounter();

            var lines = new List<string> {
                "hello",
                "world",
                "/* ",
                "hello // commented line",
                "*/",
                ""
            };
            var result = linesCounter.CountLines(lines);

            Assert.Equal(2, result["Code"]);
            Assert.Equal(5, result["Total"]);
            Assert.Equal(1, result["Comment"]);
            Assert.Equal(2, result["Blank"]);
        }
    }
}