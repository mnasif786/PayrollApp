//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Payroll.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Currency
    {
        public Currency()
        {
            this.Salaries = new HashSet<Salary>();
        }
    
        public int CurrencyId { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> ConvertionFactor { get; set; }
    
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
