using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Delegatefactory;

namespace DelegateFactoryRuntime
{
    public static class ContainerFactory
    {
        public static DelegateRuntime GetRuntime()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<QuoteService>().As<IQuoteService>();
            builder.RegisterType<Portfolio>();
            builder.RegisterType<Shareholding>();
            builder.RegisterType<DelegateRuntime>();
            var container = builder.Build();
            return container.Resolve<DelegateRuntime>();
        }
    }
}
