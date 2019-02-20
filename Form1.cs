using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIGuessTheNextStockQuote
{
    public partial class Form1 : Form
    {
        Random randomGeneratorObj = null;

        public int randNum = -1;

        public int aiGuessNum = -1;
        public int successCount = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeMethod();
        }

        private void InitializeTextValues()
        {

            lblRandStockQuote.Text = "";
            lblRandStockDate.Text = "";
            lblRandRowPosition.Text = "";


            labelAIValue.Text = "";
            labelAIBestGuessesValue.Text = "";
            labelRandValue.Text = "";
            labelRandDate.Text = "";
            labelGuessResult.Text = "";
        }

        private void InitializeMethod()
        {
            randomGeneratorObj = new Random();

            InitializeTextValues();

            //labelRandValue.Text = "";
            //labelAIValue.Text = "";
            //labelAIBestGuessesValue.Text = "";

            successCount = 0;

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{

            InitializeTextValues();
            PickARandomStockQuote();

                //StartProcess();

                //this.Update();
                // Pause
                // Sleep for 3 seconds.
                //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
            //}
        }


        private void PickARandomStockQuote()
        {


            //labelAIValue.Text = "";
            //labelRandValue.Text = "";
            //labelAIBestGuessesValue.Text = "";

            if (Globals.ReadDataFromStockQuotesFile() == false)
            {
                MessageBox.Show("Could not read quotes file: " + Globals.fileLocStockQuotes);
                return;
            }

            if ((Globals.stockQuotesHashTable == null) || (Globals.stockQuotesHashTable.Count == 0))
            {
                MessageBox.Show("Stock quote hash table is empty.");
                return;
            }


            try
            {
                // Generate the next random number  
                GenerateandDisplayNextRandomNumberQuote();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error picking a random quote." + ex.Message);
                return;
            }
        }

        private void StartProcessOfGuessingTheNextQuote()
        {

            try
            {
                // Generate the next random number  
                //GenerateandDisplayNextRandomNumberQuote();
                // Guess the next number
                aiGuessNum = AIGuessTheNextStockQuote();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing random quote." + ex.Message);
                return;
            }

            ValidatetheAIResult();

            string resultStr;

            int nextRandSeqNum = Convert.ToInt32(Globals.randStockQuote.seqNum) + 1;

            StockQuote nextStockQuote = (StockQuote)Globals.stockQuotesHashTable[nextRandSeqNum.ToString()];

            int nextRandNumPrice = Convert.ToInt32(nextStockQuote.stockPrice);
            string nextRandDateStr = nextStockQuote.date.ToString();

            if (aiGuessNum == nextRandNumPrice)
            {
                resultStr = "SUCCESS !!!";
                successCount++;
            }
            else
            {
                resultStr = "Guess Again";

            }

            labelRandDate.Text = nextRandDateStr;
            labelRandValue.Text = nextRandNumPrice.ToString();
            labelGuessResult.Text = resultStr;

            PatternNumberResult.PrintToPatternHitsFile(" ");
            PatternNumberResult.PrintToPatternHitsFile(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            PatternNumberResult.PrintToPatternHitsFile("------- Result --------");
            PatternNumberResult.PrintToPatternHitsFile("AI Stock Price Guess: " + aiGuessNum.ToString());
            PatternNumberResult.PrintToPatternHitsFile("Actual Next day Stock Price: " + nextRandNumPrice.ToString());
            //PatternNumberResult.PrintToPatternHitsFile("Random Number: " + randNum.ToString());
            PatternNumberResult.PrintToPatternHitsFile("Result: " + resultStr);
            PatternNumberResult.PrintToPatternHitsFile("----------------------------------------------------------------------");

        }

        private void GenerateandDisplayNextRandomNumberQuote()
        {
            try
            {
                randNum = randomGeneratorObj.Next(Globals.startNum, Globals.endNum);

                // Read the stock quote value from the file
                if (Globals.stockQuotesHashTable.Count > randNum)
                {
                    Globals.randStockQuote = (StockQuote)Globals.stockQuotesHashTable[randNum.ToString()];
                }

                if (Globals.randStockQuote != null)
                {
                    lblRandRowPosition.Text = Globals.randStockQuote.seqNum;
                    lblRandStockDate.Text = Globals.randStockQuote.date;
                    lblRandStockQuote.Text = Globals.randStockQuote.stockPrice;
                }
                else
                {
                    Globals.randStockQuote = null;
                    lblRandRowPosition.Text = randNum.ToString();
                    lblRandStockDate.Text = "*** not found ***";
                    lblRandStockQuote.Text = "*** not found ***";
                    Exception ex = new Exception("Could not get Random Stock quote object.");
                    throw ex;
                }
            }
            catch
            {
                throw;
            }

        }

        private void ValidatetheAIResult()
        {
            if (Globals.randStockQuote == null)
            {
                return;
            }

            string guessResult = "N";

            int randStockPrice = Convert.ToInt32(Globals.randStockQuote.stockPrice);

            labelRandValue.Text = randStockPrice.ToString();


            if ((aiGuessNum != -1) && (randStockPrice == aiGuessNum))
            {
                guessResult = "Y";
            }

            // write to summary output file

            string linetext = randStockPrice.ToString() + "," + aiGuessNum.ToString() + "," + guessResult;

            using (StreamWriter writer = new StreamWriter(Globals.fileAIResultsOutput, true))
            {
                writer.WriteLine(linetext);
            }
        }

        private int AIGuessTheNextStockQuote()
        {
            int aiGuessValue = -1;

            try
            {
                AnalyzePatternHits analyzePatternHits = new AnalyzePatternHits();

                aiGuessValue = analyzePatternHits.AnalyzePatternDataFromLogandReturnAIGuess();

                labelAIValue.Text = aiGuessValue.ToString();
                labelAIBestGuessesValue.Text = analyzePatternHits.GetAIGuessesFromPatternHits();
            }
            catch
            {
                throw;
            }

            return aiGuessValue;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int maxCounter = Convert.ToInt32(textBoxMaxCounter.Text);

            if (maxCounter > 10)
            {
                Globals.notLogVerbose = true;
            }

            for (int i = 1; i <= maxCounter; i++)
            {
                counter++;

                labelCounter.Text = counter.ToString() + " of " + maxCounter.ToString();

                StartProcessOfGuessingTheNextQuote();

                double pctSuccess = ((double)successCount / maxCounter) * 100;
                int pctSuccessRounded = (int)Math.Round(pctSuccess);

                labelCountDisplay.Text = successCount.ToString() + " of " + i.ToString();

                labelSuccessPct.Text = pctSuccessRounded.ToString() + " %";

                this.Update();
                // Pause
                // Sleep for 3 seconds.
                //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }

        private void btnGetNextDayQuote_Click(object sender, EventArgs e)
        {
            StartProcessOfGuessingTheNextQuote();
        }
    }
}
