using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Payroll.Application.Factories.Contracts;
using Payroll.Common.Models;

using Payroll.Domain.RepositoryContracts;

namespace Payroll.Application.Factories.Implementations
{
    public class EmployeeFactory : IEmployeeFactory
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeFactory(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<EmployeeModel> GetEmployeesWithAnnualSalaryDetail(string employeeName)
        {
            //Employee Entity returned
            var employeesList = _employeeRepository.GetEmployeeWithAnnualSalaryDetails(employeeName).ToList();

            //Maps to returning Model
            return employeesList
                    .Select(employee => EmployeeModel.Create(employee));

        }

        public IEnumerable<EmployeeModel> GetStaffLevelEmployeesWithAnnualSalaryDetail()
        {
            //Employee Entity returned
            var employeesList = _employeeRepository.GetStaffLevelEmployeeWithAnnualSalaryDetails().ToList();

            //Maps to returning Model
            return employeesList
                .Select(EmployeeModel.Create)
                .OrderByDescending( x => x.Salary.AnnualAmountInGBP);
        }
    }
}
