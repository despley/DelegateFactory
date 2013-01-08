using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatefactory
{
    public class Shareholding
    {
        public delegate Shareholding Factory(string symbol, uint holding);
        IQuoteService QuoteService { get; set; }
        public Shareholding(string symbol, uint holding, IQuoteService quoteService)
        {
            QuoteService = quoteService;
            Symbol = symbol;
            Holding = holding;
        }

        public string Symbol { get; private set; }

        public uint Holding { get; set; }

        public decimal Value
        {
            get
            {
                return QuoteService.GetQuote(Symbol) * Holding;
            }
        }
    }
}
