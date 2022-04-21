namespace CodeEstimator
{
    public interface ILineCounter
    {
        public void Count(string line);
        public int LineCount { get; }
    }
}