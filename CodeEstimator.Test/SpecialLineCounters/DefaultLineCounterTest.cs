using CodeEstimator.SpecialLineCounters;
using Xunit;

namespace CodeEstimator.Test
{
    public class DefaultLineCounterTest
    {
        [Fact]
        public void DefaulLineCounter_ShouldCountAllLinesWithoutCondition()
        {
            var lineCounter = new DefaultLineCounter();

            lineCounter.Count("     // hello");
            lineCounter.Count("world");
            lineCounter.Count("  ");

            Assert.Equal(3, lineCounter.LineCount);
        }
    }
}