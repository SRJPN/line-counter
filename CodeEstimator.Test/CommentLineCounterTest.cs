using Xunit;

namespace CodeEstimator.Test
{
    public class CommentLineCounterTest
    {
        [Fact]
        public void CommentLineCounter_ShouldCountCommentedLines()
        {
            var lineCounter = new CommentLineCounter();

            lineCounter.Count("// hello");
            lineCounter.Count("world");

            Assert.Equal(1, lineCounter.LineCount);
        }

        [Fact]
        public void CommentLineCounter_ShouldIgnoreSingleSlash()
        {
            var lineCounter = new CommentLineCounter();

            lineCounter.Count("/ hello");
            lineCounter.Count("world");

            Assert.Equal(0, lineCounter.LineCount);
        }


        [Fact]
        public void CommentLineCounter_ShouldCountCommentedLinesEvenWithSpaceInFront()
        {
            var lineCounter = new CommentLineCounter();

            lineCounter.Count("     // hello");
            lineCounter.Count("world");

            Assert.Equal(1, lineCounter.LineCount);
        }
    }
}