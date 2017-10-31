using System;
using DTL.MRA.Customers.API.Data;
using DTL.MRA.Customers.API.Models;

namespace DTL.MRA.Customers.API.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerDbContext context) : base(context)
        {
        }

        public CustomerDbContext CustomerDbContext
        {
            get { return Context as CustomerDbContext; }
        }
    }
}
