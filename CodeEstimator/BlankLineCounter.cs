using System.Text.RegularExpressions;

namespace CodeEstimator
{
    public class BlankLineCounter : ISpecialLineCounter
    {
        private string blankLineRegex = "^(\\s+)?$";
        public int LineCount { get; private set; } = 0;

        public string Name => "Blank";

        public void Count(string line)
        {
            var matchCollection = Regex.Matches(line, blankLineRegex);

            if (matchCollection.Count > 0)
            {
                LineCount++;
            }
        }
    }
}