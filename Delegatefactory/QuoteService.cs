using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Delegatefactory.StockQuoteService;
namespace Delegatefactory
{
    public class QuoteService : IQuoteService
    {
        public decimal GetQuote(string symbol)
        {
            var s = new StockQuoteSoapClient();
            var doc = new XmlDocument();
            doc.LoadXml(s.GetQuote(symbol));
            var ele = doc.SelectSingleNode("StockQuotes/Stock/Last");
            return Convert.ToDecimal(ele.InnerText);
        }
    }
}
