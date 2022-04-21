using CodeEstimator.SpecialLineCounters;
using Xunit;

namespace CodeEstimator.Test
{
    public class CommentBlockLineCounterTest
    {
        [Fact]
        public void CommentBlockLineCounter_ShouldCountSinglelineCommentBlock()
        {
            var lineCounter = new CommentBlockLineCounter();

            lineCounter.Count("/* hello */");
            lineCounter.Count("world");

            Assert.Equal(1, lineCounter.LineCount);
        }

        [Fact]
        public void CommentBlockLineCounter_ShouldCountEmptyCommentBlockStart()
        {
            var lineCounter = new CommentBlockLineCounter();

            lineCounter.Count("/*");
            lineCounter.Count("hello */");
            lineCounter.Count("world");

            Assert.Equal(2, lineCounter.LineCount);
        }


        [Fact]
        public void CommentBlockLineCounter_ShouldCountEmptyCommentBlockEnd()
        {
            var lineCounter = new CommentBlockLineCounter();

            lineCounter.Count("/* hello");
            lineCounter.Count(" */");
            lineCounter.Count("world");

            Assert.Equal(2, lineCounter.LineCount);
        }
    }
}