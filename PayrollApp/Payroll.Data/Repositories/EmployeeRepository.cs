using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Data.Common;
using Payroll.Data.Contracts;
using Payroll.Domain.Entities;
using Payroll.Domain.Entities.Enums;
using Payroll.Domain.RepositoryContracts;

namespace Payroll.Data.Repositories
{
    public class EmployeeRepository: PayrollRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IPayrollDbContextManager payrollDbContextManager) : base(payrollDbContextManager)
        {
        }

        public IEnumerable<Employee> GetEmployeeWithAnnualSalaryDetails(string employeeName)
        {
            return Context.Employees.Where(e => e.Name.Equals(employeeName)).Include(s => s.Salaries);
        }

        public IEnumerable<Employee> GetStaffLevelEmployeeWithAnnualSalaryDetails()
        {
            return Context.Employees.Where(e => e.RoleId == (int) RoleTypes.Staff ).Include(s => s.Salaries);
        }
    }
}
