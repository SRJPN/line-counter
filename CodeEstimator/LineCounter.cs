namespace CodeEstimator
{
    public class LineCounter : ILineCounter
    {
        public void Count(string line)
        {
            LineCount ++;
        }

        public int LineCount { get; internal set; } = 0;
    }
}