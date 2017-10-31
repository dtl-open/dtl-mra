using System;
using DTL.MRA.Customers.API.Repositories;

namespace DTL.MRA.Customers.API.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        int Complete();
    }
}
