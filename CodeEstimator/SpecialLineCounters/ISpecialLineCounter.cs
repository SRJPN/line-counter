namespace CodeEstimator.SpecialLineCounters
{
    public interface ISpecialLineCounter
    {
        public string Name { get; }
        public bool Count(string line);
        public int LineCount { get; }
    }
}