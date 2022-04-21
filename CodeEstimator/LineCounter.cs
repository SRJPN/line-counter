using System.Collections.Generic;
using System.Linq;
using CodeEstimator.SpecialLineCounters;

namespace CodeEstimator
{
    public class LineCounter
    {
        private readonly IEnumerable<ISpecialLineCounter> specialLineCounters;

        public LineCounter()
        {
            var specialLineCounters = new List<ISpecialLineCounter>() {
                new CommentLineCounter(),
                new BlankLineCounter()
            };
            this.specialLineCounters = specialLineCounters;
        }

        public IDictionary<string, int> CountLines(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                RunSpecialLineCounters(line);
            }
            return FormatResult(lines);
        }

        private IDictionary<string, int> FormatResult(IEnumerable<string> lines)
        {
            var result = new Dictionary<string, int>();
            foreach (var counter in specialLineCounters)
            {
                result.Add(counter.Name, counter.LineCount);
            }
            result.Add("Code", lines.Count() - FindSpecialLinesCount());
            result.Add("Total", lines.Count());

            return result;
        }

        private void RunSpecialLineCounters(string line) {
            foreach(var counter in specialLineCounters) {
                if(counter.Count(line))
                    break;
            }
        }

        private int FindSpecialLinesCount() {
            return specialLineCounters.Sum(x => x.LineCount);
        }
    }
}