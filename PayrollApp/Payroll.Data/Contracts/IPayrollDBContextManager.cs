using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Domain;

namespace Payroll.Data.Contracts
{
    public interface IPayrollDbContextManager: IDisposable
    {
        PayRollEntities Context { get;  }
        DbContextTransaction BeginTransaction();
        void Rollback();
        void Save();
    }
}
