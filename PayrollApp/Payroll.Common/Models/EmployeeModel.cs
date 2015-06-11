using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Payroll.Domain.Entities;

namespace Payroll.Common.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public SalaryModel Salary { get; set; }
       

        public static EmployeeModel Create(Employee employee)
        {
            if (employee == null) 
                return null;

            var employeeModel = new EmployeeModel
            {
                Name =  employee.Name,
                Salary = SalaryModel.Create(employee.Salaries.SingleOrDefault()) //In real time employee can have on one salary
               
            };

            return employeeModel;
        }
    }
}
