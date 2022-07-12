using System.Text.RegularExpressions;

namespace CodeEstimator.SpecialLineCounters
{
    public class CommentBlockLineCounter : ISpecialLineCounter
    {
        private string commentBlockStartRegex = "/\\*";
        private string commentBlockEndRegex = "\\*/";
        private bool isInCommentBlock = false;
        public int LineCount { get; private set; } = 0;

        public string Name => "Comment Block";

        public bool Count(string line)
        {
            var counted = false;
            if (IsCommentBlockEnd(line))
            {
                LineCount++;
                counted = true;
                isInCommentBlock = false;
            }
            if (IsCommentBlockStart(line))
            {
                isInCommentBlock = true;
            }
            if (isInCommentBlock)
            {
                LineCount++;
                counted = true;
            }
            return counted;
        }

        private bool IsCommentBlockEnd(string line)
        {
            var matchCollection = Regex.Matches(line, commentBlockEndRegex);
            return matchCollection.Count > 0;
        }

        private bool IsCommentBlockStart(string line)
        {
            var matchCollection = Regex.Matches(line, commentBlockStartRegex);
            return (matchCollection.Count > 0);
        }
    }
}