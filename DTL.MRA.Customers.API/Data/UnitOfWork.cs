using System;
using DTL.MRA.Customers.API.Repositories;

namespace DTL.MRA.Customers.API.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerDbContext _context;

        public UnitOfWork(CustomerDbContext context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
        }

        public ICustomerRepository Customers { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
