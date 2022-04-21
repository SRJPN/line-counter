using System.Text.RegularExpressions;

namespace CodeEstimator
{
    public class CommentLineCounter : ISpecialLineCounter
    {
        private string commentRegex = "//";
        public int LineCount { get; private set; } = 0;

        public string Name => "Comment";

        public void Count(string line)
        {
            var matchCollection = Regex.Matches(line, commentRegex);

            if(matchCollection.Count > 0) {
                LineCount ++;
            }
        }
    }
}