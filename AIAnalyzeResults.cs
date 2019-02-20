using AIGuessTheNextStockQuote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGuessTheNextRandomNumber
{


    public class AIResults
    {
        public string Section = "";
        public bool ContainsResult = false;
        
        public AIResults()
        {

        }
    }

    public class AIAnalyzeResults
    {
        public AIAnalyzeResults()
        {

        }

        // https://www.codeproject.com/Articles/832714/Query-Custom-Collections-in-Csharp-with-LINQ

        static IEnumerable<PatternNumberResult> GetPatternHits(IEnumerable<PatternNumberResult> patternHitList, int seqNumStart, int seqNumEnd)
        {
            IEnumerable<PatternNumberResult> patternHitSet =
                from PatternNumberResult in patternHitList
                where PatternNumberResult.seqNum > seqNumStart && PatternNumberResult.seqNum <= seqNumEnd
                select PatternNumberResult;

            return patternHitSet;
        }
    }
}
