using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payroll.Common.Models;


namespace Payroll.Application.Factories.Contracts
{
    public interface IEmployeeFactory
    {
        IEnumerable<EmployeeModel> GetEmployeesWithAnnualSalaryDetail(string employeeName);

        IEnumerable<EmployeeModel> GetStaffLevelEmployeesWithAnnualSalaryDetail();
    }
}
