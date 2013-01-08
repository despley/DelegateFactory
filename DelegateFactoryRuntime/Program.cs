using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Delegatefactory;

namespace DelegateFactoryRuntime
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerFactory.GetRuntime().Go();
        }
    }
}
