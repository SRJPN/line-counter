using Xunit;

namespace CodeEstimator.Test
{
    public class LineCounterTest
    {
        [Fact]
        public void LineCounter_ShouldCountAnyLines()
        {
            var lineCounter = new LineCounter();
        
            lineCounter.Count("hello");
            lineCounter.Count("World");

            Assert.Equal(2, lineCounter.LineCount);
        }
    }
}