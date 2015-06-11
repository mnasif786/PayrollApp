using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Domain.Entities;
using Payroll.Domain.Entities.Enums;

namespace Payroll.Common.Models
{
    public class SalaryModel
    {
        public decimal AnnualAmountInLocal { get; set; }
        public decimal AnnualAmountInGBP { get; set; }
        public string LocalUnit { get; set; }

        public static SalaryModel Create(Salary salary)
        {
            if (salary != null)
            {
                var currency = salary.Currency;
                var salaryModel = new SalaryModel
                {
                    AnnualAmountInLocal = salary.AnnualAmount,
                    LocalUnit = currency.Unit
                };

                if (currency.Unit.ToUpper() != CurrencyType.GBP.ToString().ToUpper()) //just an extra check
                {
                    salaryModel.AnnualAmountInGBP = (decimal)((salary.AnnualAmount * 1) / currency.ConvertionFactor);
                }

                return salaryModel;
            }

            return null;
        }

    }

    
}
