namespace CodeEstimator.SpecialLineCounters
{
    public class DefaultLineCounter : ISpecialLineCounter
    {
        public string Name => "Code";

        public int LineCount { get; private set; } = 0;

        public bool Count(string line)
        {
            LineCount++;
            return true;
        }
    }
}