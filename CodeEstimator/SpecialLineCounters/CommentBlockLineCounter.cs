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
            var result = false;
            CheckIfCommentBlockStart(line);
            if (isInCommentBlock)
            {
                LineCount++;
                result = true;
            }
            CheckIfCommentBlockEnd(line);
            return result;
        }

        private void CheckIfCommentBlockEnd(string line)
        {
            var matchCollection = Regex.Matches(line, commentBlockEndRegex);
            if (matchCollection.Count > 0)
            {
                isInCommentBlock = false;
            }
        }

        private void CheckIfCommentBlockStart(string line)
        {
            var matchCollection = Regex.Matches(line, commentBlockStartRegex);
            if (matchCollection.Count > 0)
            {
                isInCommentBlock = true;
            }
        }
    }
}