using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Domain.Common.Contracts;
using Payroll.Domain.Entities;

namespace Payroll.Domain.RepositoryContracts
{
    public interface IEmployeeRepository : IPayRollRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeeWithAnnualSalaryDetails(string employeeName);

        IEnumerable<Employee> GetStaffLevelEmployeeWithAnnualSalaryDetails();
    }
}
