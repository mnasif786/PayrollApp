using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Application.Common;
using Payroll.Application.Factories.Contracts;
using StructureMap.Configuration.DSL;

namespace PayrollApp
{
    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
             For<IPayroll>().Use<Payroll>();

            Configure(x => x.ImportRegistry(typeof(ApplicationRegistry)));
        }
         
    }
}
