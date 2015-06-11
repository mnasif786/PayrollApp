using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payroll.Data.Contracts;
using Payroll.Data.Repositories;
using Payroll.Domain.RepositoryContracts;
using Registry = StructureMap.Configuration.DSL.Registry;

namespace Payroll.Data.Common
{
    public class PayrollDataRegistry: Registry
    {
        public PayrollDataRegistry()
        {
            For<IPayrollDbContextManager>().Use<PayrollDbContextManager>();
            For<IEmployeeRepository>().Use<EmployeeRepository>();
        }
    }
}
