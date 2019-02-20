using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGuessTheNextStockQuote
{
    public class StockQuote
    {
        public string date;
        public string seqNum;
        public string stockPrice;

        public StockQuote(string date, string seqNum, string stockPrice)
        {
            this.date = date;
            this.seqNum = seqNum;
            this.stockPrice = stockPrice;
        }

    }
}
