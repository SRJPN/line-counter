namespace CodeEstimator
{
    public interface ISpecialLineCounter
    {
        public string Name { get; }
        public void Count(string line);
        public int LineCount { get; }
    }
}