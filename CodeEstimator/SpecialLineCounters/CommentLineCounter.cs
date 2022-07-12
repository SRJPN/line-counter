using System.Text.RegularExpressions;

namespace CodeEstimator.SpecialLineCounters
{
    public class CommentLineCounter : ISpecialLineCounter
    {
        private string commentRegex = "^(\\s+)?//";

        public int LineCount { get; private set; } = 0;

        public string Name => "Comment";

        public bool Count(string line)
        {
            if (IsMatchingLine(line))
            {
                LineCount++;
                return true;
            }
            return false;
        }

        private bool IsMatchingLine(string line)
        {
            return Regex.Matches(line, commentRegex).Count > 0;
        }
    }
}