using System;
using DTL.MRA.MeterReads.API.Repositories;

namespace DTL.MRA.MeterReads.API.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IMeterReadsRepository MeterReads { get; }
        int Complete();
    }
}
