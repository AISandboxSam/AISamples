using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AIGuessTheNextStockQuote
{
    class AnalyzePatternHits
    {

        private List<PatternNumberResult> patternHitsList = new List<PatternNumberResult>();
        //private PatternNumberResult patternNumberResults = null;


        public AnalyzePatternHits()
        {

        }


        private int NumOfOccurOfNextVal(string nextVal)
        {
            int numOfOccur = 0;

            foreach(PatternNumberResult pn in patternHitsList)
            {
                // each number is treated as a string as the value is followed by a comma
                if (pn.nextVal.Trim() == nextVal.Trim())
                {
                    numOfOccur++;
                }
            }

            return numOfOccur;

        }

        private void PrintPatternHitsToLogFile()
        {

            //using (StreamWriter writer = new StreamWriter(filePatternHits, true))
            //{
            //writer.WriteLine();
            //writer.WriteLine(PatternHits.PatternHitsHeader());

            if (Globals.notLogVerbose == false)
            {
                PatternNumberResult.PrintToPatternHitsFile(PatternNumberResult.PatternHitsHeader());
                for (int i = 0; i < patternHitsList.Count; i++)
                {
                    PatternNumberResult phit = patternHitsList[i];

                    PatternNumberResult.PrintToPatternHitsFile(phit.PatternHitsPrint());
                    //writer.WriteLine(phit.PatternHitsPrint());
                }
            }
            //}

        }


        public int AnalyzePatternDataFromLogandReturnAIGuess()
        {
            int aiReturnValue = 0;

            // get most likely match from log

            //IdentifyStringPatterns(Globals.stockQuotesListDelimComma);

            // new - using wild card


            // we can no longer use all the data in the stock quote file
            // but instead we can only go upto the selected random row
            // therefore, we create a new list

            int randStockRow = Convert.ToInt32(Globals.randStockQuote.seqNum);
            List<string> listNumUptilRandomNum = new List<string>();
            listNumUptilRandomNum = Globals.stockQuotesListDelimComma.GetRange(0, randStockRow);

            IdentifyStringPatternsUsingWildcards(listNumUptilRandomNum);

            PrintPatternHitsToLogFile();

            if (patternHitsList.Count > 0)
            {
                aiReturnValue = GetAIGuessFromPatternHits(patternHitsList);
            }

            return aiReturnValue;

        }

        // In this method we use regex in order to use wild cards in the string for example, if we have a pattern 100, 111, 122
        // 100 100 100  *
        // 111 111  *  111 
        // 122  *  122 122
        // asterisk indicates wild card, therefore, search for a string such as 122, * - any, 100

        private void IdentifyStringPatternsUsingWildcards(List<string> listNumUptilRandomNum)
        {
            patternHitsList.Clear();

            bool wildCardOn = false;
            int listLen = Convert.ToInt32(Globals.randStockQuote.seqNum);

            //int numofDigitsToMatch = randStockRow;

            string strArrayNumUptilRandStringDelim = string.Join("", listNumUptilRandomNum.ToArray());

            if (Globals.notLogVerbose == false)
            {
                //PatternNumberResult.PrintToPatternHitsFile("-------------------------------------------");
                PatternNumberResult.PrintToPatternHitsFile("Randomly Chosen Stock Quote: " + Globals.randStockQuote.date.ToString() + " - " + Globals.randStockQuote.seqNum + " - " + Globals.randStockQuote.stockPrice);
                PatternNumberResult.PrintToPatternHitsFile(strArrayNumUptilRandStringDelim);
            }

            string searchPattern = "";
            //int numOfWildCards = 1; // for now, we will limit to one
            var wildCardPosList = new List<int>();

            for (int currDigitsToMatch = 1; currDigitsToMatch <= Globals.maxDigitsToMatch; currDigitsToMatch++)
            {

                // Loop through all instances of the searchPattern
                //string occurString = "";

                int seqNum = 0;

                if (listLen < currDigitsToMatch)
                {
                    throw (new Exception("Digits to match greater than the length of data."));
                }

                // get the last digit in the list, then append to the right its predecessor and so on
                int newPos = listLen - currDigitsToMatch;
                string newPattern = listNumUptilRandomNum[newPos].ToString();
                searchPattern = newPattern + searchPattern;

                // If just one item to match, then no use of wild card
                //if (currDigitsToMatch == 1)
                //{
                //    continue;
                //}

                string patternRegexStr = "";

                // when pos is -1, then no wild card
                for (int wildCardPos = -1; wildCardPos < currDigitsToMatch; wildCardPos++)
                {
                    wildCardOn = false;

                    // If just one item to match, then no use of wild card
                    if (currDigitsToMatch > 1)
                    {
                        if (wildCardPos == -1)
                        {
                            // no wild card, first work with the pattern string as is
                            patternRegexStr = searchPattern;

                            wildCardPosList.Clear();
                        }
                        else
                        {
                            // We do not want the wild card to be in the last position such as in example 5,6,7
                            // we want wild card in the positions 5,\d,\d or 5,6,\d
                            // but not in \d,6,7 or \d,\d,7
                            if (wildCardPos == (currDigitsToMatch-1))
                            {
                                continue;
                            }
                            wildCardOn = true;
                            wildCardPosList.Add(wildCardPos);
                            patternRegexStr = CreatePatternRegexStr(searchPattern, wildCardPosList);
                        }
                    }
                    else
                    {
                        patternRegexStr = searchPattern;
                    }


                    int pos = 0;
                    //int countOccur = 0;

                    int numOfPatternOccurrances = 0;

                    // Get second wild card.
                    Match match = Regex.Match(strArrayNumUptilRandStringDelim, patternRegexStr);
                    // get total num of matches
                    int matchCount = Regex.Matches(strArrayNumUptilRandStringDelim, patternRegexStr).Count;

                    int currMatchCount = 0;
                    // pos is zero based, and starts from left to right
                    while (currMatchCount < matchCount)
                    {
                        numOfPatternOccurrances++;

                        pos = match.Index;

                        // zero based -  pattern includes the leading comma such as 76,72,
                        int posAfter = match.Index + match.Value.Length;
                        //int posAfter = pos + (searchPattern.Length); //skip over the length of search pattern to get the next token 2,3,

                        // adding 1 to posAfter as it is zero based while length is not
                        if (posAfter + 1 > strArrayNumUptilRandStringDelim.Length)
                        {
                            break;
                        }

                        //string valAfter = listNumUptilRandomNum[pos+1].ToString();
                        //if (posAfter >= strNumUptilRandStringDelim.Length)
                        //{
                        //    break;
                        //}

                        // get the value immediately after the pattern
                        // zero based position of the next delimiter string 
                        int nextValEndpos = strArrayNumUptilRandStringDelim.IndexOf(',', posAfter);
                        // zero based
                        // plus one to get the comma
                        int valAfterLen = (nextValEndpos - posAfter) + 1;

                        // get the next value after the pattern with the comma
                        string valAfter = strArrayNumUptilRandStringDelim.Substring(posAfter, valAfterLen);


                        //string currOccurString = searchPattern + valAfter + "|";
                        //int countOccur = Globals.CountOccurancesofStringWithinString(currOccurString, occurString);
                        //occurString += currOccurString;

                        int countOccur = NumOfOccurOfNextVal(valAfter);

                        //seqNum++;

                        //int weightage = (currDigitsToMatch * weightFactor);
                        //double weightage = Math.Pow(Globals.weightFactor, currDigitsToMatch);

                        //double calcWeightage = weightage;

                        //countOccur++;

                        //if (countOccur > 0)
                        //{
                        //calcWeightage = weightage + (countOccur * currDigitsToMatch);
                        //}

                        int weightage = 0;
                        double calcWeightage = 0;

                        if (wildCardOn == true)
                        {
                            weightage = Globals.weightFactorWithWildCard;
                        }
                        else
                        {
                            weightage = Globals.weightFactor;
                        }

                        calcWeightage = weightage + countOccur;

                        PatternNumberResult phits = new PatternNumberResult(++seqNum, patternRegexStr, valAfter, weightage, pos, currDigitsToMatch, countOccur, calcWeightage);

                        patternHitsList.Add(phits);


                        // Increment the index.
                        //pos++;

                        currMatchCount++;

                        match = match.NextMatch();
                    }

                    // we will always have occurance of one pattern in the end of the array string, but if 
                    // no other pattern was found in the string, it is time to return
                    if (numOfPatternOccurrances <= 1)
                    {
                        return;
                    }
                }

            }

        }

        private string CreatePatternRegexStr(string searchPattern, List<int> wildCardPosList)
        {
            string patternRegexStr = "";

            string[] patternElements = searchPattern.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            int currPos = 1;

            //foreach (int wildCardPos in wildCardPosList)
            //{
                // our string pattern will look something like 1,2,3,4,
                // if we plan to insert wild card in the first position then it will go where 4 is
                // therefore, we need to insert it in the last position
                //int newWildCardPos = patternElements.Length - wildCardPos;

                foreach (string patternElement in patternElements)
                {
                    if (wildCardPosList.IndexOf(currPos) != -1)
                    //if (currPos == newWildCardPos)
                    {
                        patternRegexStr += @"\d+,";
                    }
                    else
                    {
                        patternRegexStr += patternElement + ',';
                    }

                    currPos++;

                }
            //}

            return patternRegexStr;
        }

        private int GetAIGuessFromPatternHits(List<PatternNumberResult> phList)
        {
            int bestGuess = 0;

            PatternNumberResult bestPhit = null;
            string bestGuessStr = "0,";
            double maxWeightageSofar = 0;

            foreach(PatternNumberResult phit in phList)
            {
                if (maxWeightageSofar < phit.calcWeightage)
                {
                    maxWeightageSofar = phit.calcWeightage;
                    bestGuessStr = phit.nextVal;

                    bestPhit = phit;
                }
            }

            PatternNumberResult.PrintToPatternHitsFile("-- selected winner --");
            PatternNumberResult.PrintToPatternHitsFile(bestPhit.PatternHitsPrint());

            bestGuessStr = bestGuessStr.TrimEnd(new char[] { ',' });

            bestGuess = Convert.ToInt32(bestGuessStr);

            // Determine max weightage 
            return bestGuess;
        }

        public string GetAIGuessesFromPatternHits()
        {
            string bestGuesses = "";

            PatternNumberResult bestPhit = null;
            string bestGuessStr = "0,";
            double maxWeightageSofar = 0;

            List<PatternNumberResult> phBestHitsList = new List<PatternNumberResult>();

            foreach (PatternNumberResult phit in patternHitsList)
            {
                if (maxWeightageSofar < phit.calcWeightage)
                {
                    maxWeightageSofar = phit.calcWeightage;
                    bestGuessStr = phit.nextVal;

                    bestPhit = phit;
                }
            }

            // Get all best pattern hits with max weightage
            foreach(PatternNumberResult phit in patternHitsList)
            {
                if (phit.calcWeightage == bestPhit.calcWeightage)
                {
                    phBestHitsList.Add(phit);
                    bestGuesses += phit.nextVal;
                }
            }
            PatternNumberResult.PrintToPatternHitsFile("-- winners --");
            foreach (PatternNumberResult phit in phBestHitsList)
            {
                PatternNumberResult.PrintToPatternHitsFile(phit.PatternHitsPrint());
            }

            //bestGuessStr = bestGuessStr.TrimEnd(new char[] { ',' });

            //bestGuess = Convert.ToInt32(bestGuessStr);

            // Determine max weightage 
            return bestGuesses;
        }

    }


}
