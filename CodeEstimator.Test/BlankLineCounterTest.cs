using Xunit;

namespace CodeEstimator.Test
{
    public class BlankLineCounterTest
    {
        [Fact]
        public void BlankLineCounter_ShouldCountBlankLines()
        {
            var lineCounter = new BlankLineCounter();

            lineCounter.Count("");
            lineCounter.Count("         ");
            lineCounter.Count(" ");
            lineCounter.Count("world");

            Assert.Equal(3, lineCounter.LineCount);
        }
    }
}