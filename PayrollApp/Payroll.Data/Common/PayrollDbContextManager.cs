using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Data.Contracts;
using Payroll.Domain;

namespace Payroll.Data.Common
{
    public class PayrollDbContextManager : IPayrollDbContextManager
    {
        private bool _disposed;

        private readonly PayRollEntities _context;


        public PayrollDbContextManager(PayRollEntities context)
        {
            _context = context;
        }

        public PayRollEntities Context { get { return _context; } }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        

        public DbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
