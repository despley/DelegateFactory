using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegatefactory;
namespace DelegateFactoryRuntime
{
    public class DelegateRuntime
    {
        private Portfolio  _portfolio;
        public DelegateRuntime(Portfolio portfolio)
        {
            _portfolio = portfolio;
        }

        public void Go()
        {
            _portfolio.Add("PRO.L", 200);
            _portfolio.Add("GOOG", 100);
            _portfolio.Add("BP.L", 123);
            System.Diagnostics.Trace.WriteLine(_portfolio.Value);
        }
    }
}
