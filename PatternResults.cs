using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGuessTheNextStockQuote
{

    public class PatternNumberResult
    {
        public int seqNum;
        public string pattern;
        public string nextVal;
        public double weightage;
        public int findOrder;
        public int searchItems;
        public int prevOccurCount;
        public double calcWeightage;

        public PatternNumberResult(int seqNum, string pattern, string nextVal, double weightage, int findOrder, int searchItems, int prevOccurCount, double calcWeightage)
        {
            this.seqNum = seqNum;
            this.pattern = pattern;
            this.nextVal = nextVal;
            this.weightage = weightage;
            this.findOrder = findOrder;
            this.searchItems = searchItems;
            this.prevOccurCount = prevOccurCount;
            this.calcWeightage = calcWeightage;
        }

        public static string PatternHitsHeader()
        {
            string printString = "seqNum|pattern|nextVal|weightage|findOrder|searchItems|prevOccurCount|calcWeightage";
            return printString;
        }

        public string PatternHitsPrint()
        {
            string printString = seqNum.ToString() + "|" + pattern + "|" + nextVal + "|" + weightage.ToString() + "|" + findOrder.ToString() + "|" + searchItems.ToString() + "|" + prevOccurCount.ToString() + "|" + calcWeightage.ToString();

            return printString;
        }

        public static string filePatternHits = @"AIPatternHitsThisSession.txt";

        public static void PrintToPatternHitsFile(string printLine)
        {
            using (StreamWriter writer = new StreamWriter(filePatternHits, true))
            {
                //writer.WriteLine();
                writer.WriteLine(printLine);
            }

        }


    }
}
