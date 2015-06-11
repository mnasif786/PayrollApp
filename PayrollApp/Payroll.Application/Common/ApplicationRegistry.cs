using Payroll.Application.Factories.Contracts;
using Payroll.Application.Factories.Implementations;
using Payroll.Data.Common;
using StructureMap.Configuration.DSL;

namespace Payroll.Application.Common
{
    public class ApplicationRegistry:Registry
    {

        public ApplicationRegistry()
        {
            For<IEmployeeFactory>().Use<EmployeeFactory>();

            Configure(x => x.ImportRegistry(typeof(PayrollDataRegistry)));
        }

        
    }
}
