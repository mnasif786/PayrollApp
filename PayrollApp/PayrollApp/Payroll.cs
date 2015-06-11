using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Application.Factories.Contracts;

namespace PayrollApp
{
    public class Payroll : IPayroll
    {
        private readonly IEmployeeFactory _employeeFactory;
        public Payroll(IEmployeeFactory employeeFactory)
        {
            _employeeFactory = employeeFactory;
        }

        public void Run()
        {
            DisplayEmployeePaymentReport();

            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("\n");
            
            DisplayStaffLevelEmployeePaymentReport();
            
            Console.ReadLine();
        }

        private void DisplayEmployeePaymentReport()
        {
            Console.WriteLine("*********Employee Payment Report**************");
            Console.WriteLine("\r\n");

            //Consider user enter this name on command line.
            var employeeName = "Homer Simpson";

            var employeesList = _employeeFactory.GetEmployeesWithAnnualSalaryDetail(employeeName).ToList();

            employeesList.ForEach(employee =>
                Console.WriteLine("Employee Name: {0},\r\nAnnual Salary(In Local Unit {1}): {2},\r\nAnnual Salary In GBP: {3}",
                    employee.Name, employee.Salary.LocalUnit, (float)employee.Salary.AnnualAmountInLocal,
                    (float)employee.Salary.AnnualAmountInGBP)
                );
        }

        private void DisplayStaffLevelEmployeePaymentReport()
        {

            Console.WriteLine("*********Staff Level Employee Payment Report**************");
            Console.WriteLine("\r\n");

            var employeesList = _employeeFactory.GetStaffLevelEmployeesWithAnnualSalaryDetail().ToList(); //Order by desc is calculated inside this calling factory method

            employeesList.ForEach(employee =>
                Console.WriteLine("Employee Name: {0},\r\nAnnual Salary(In Local Unit {1}): {2},\r\nAnnual Salary In GBP: {3} \r\n",
                    employee.Name, employee.Salary.LocalUnit, (float)employee.Salary.AnnualAmountInLocal, (float)employee.Salary.AnnualAmountInGBP)
                );

           
        }
    }
}
