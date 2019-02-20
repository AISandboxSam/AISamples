using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGuessTheNextStockQuote
{
    static class SubstringExtensions
    {
        /// <summary>
        /// Get string value after [last] a.
        /// </summary>
        public static string NextQuote(this string value, int startpos, string enddelim)
        {
            if (startpos == -1)
            {
                return "";
            }
            //int startpos = value.IndexOf(a);
            int posend = value.IndexOf(enddelim, startpos);

            if (posend == -1)
            {
                return "";
            }
            //int adjustedPosA = startpos + a.Length;
            if (startpos >= posend)
            {
                return "";
            }
            return value.Substring(startpos, posend);
        }
    }
    public class Globals
    {
        public static int startNum = 1;
        public static int endNum = 2518;

        public static int maxDigitsToMatch = 10;

        public static StockQuote randStockQuote = null;

        //bool existsAIFileLog = true;
        public static bool existsAIGuessTheNextStockQuote = true;

        //public static string fileLocAIGuessTheNextStockQuote = @"AIGuessTheNextStockQuote.txt";
        public static string fileLocStockQuotes = @"HistoricalQuotes_AAPL.txt";
        public static string fileAIResultsOutput = @"AIResultsOutput.txt";

        public static bool notLogVerbose = false;

        public static int weightFactor = 1; // when searching for one match it will be 1 x 10, with two it will be 2 x 10
        public static int weightFactorWithWildCard = 1;

        //public static int weightFactor = 1; // giving it the same weightage, irrespective of how many items were matched in the pattern string

        public static List<string> stockQuotesListDelimComma = new List<string>();
        public static List<string> stockQuotesListUntilRandRow = new List<string>();

        public static Hashtable stockQuotesHashTable = new Hashtable();

        public static bool ReadDataFromStockQuotesFile()
        {

            if (File.Exists(Globals.fileLocStockQuotes) == false)
            {
                return false;
            }

            bool retval = true;

            try
            {
                var fileStream = new FileStream(Globals.fileLocStockQuotes, FileMode.Open, FileAccess.Read);

                stockQuotesListDelimComma.Clear();
                stockQuotesHashTable.Clear();

                using (var streamReader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Trim().Length == 0)
                        {
                            continue;
                        }

                        //lineList.Add(line);
                        // each line should have data in the format <Number>,<Y-Match, N-No match>       
                        string[] tokens = line.Split(',');
                        string stockdate = tokens[0];
                        string seqnum = tokens[1];
                        string stockquote = tokens[2];

                        // adding a comma to each number, so that we can create a string pattern of numbers
                        // such as 1,2,3,4, and then look for patterns in the string
                        stockQuotesListDelimComma.Add(stockquote + ",");

                        StockQuote sq = new StockQuote(stockdate, seqnum, stockquote);
                        stockQuotesHashTable.Add(seqnum, sq);

                    }
                }
                //lines = lineList.ToArray();
            }
            catch
            {
                retval = false;
            }

            return retval;
        }

        public static int CountOccurancesofStringWithinString(string currOccurString, string occurString)
        {
            int numOccur = 0;

            int i = 0;
            while ((i = occurString.IndexOf(currOccurString, i)) != -1)
            {
                i += currOccurString.Length;
                numOccur++;
            }

            return numOccur;
        }
    }
}
