using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payroll.Application.Factories.Contracts;
using Payroll.Application.Factories.Implementations;
using PayrollApp;

namespace PayrollSystemConsole
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var container = IocConfig.Setup();
            var payroll = container.GetInstance<IPayroll>();
            payroll.Run();
        }
    }
}
