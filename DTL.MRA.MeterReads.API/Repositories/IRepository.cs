using System;
using System.Collections.Generic;

namespace DTL.MRA.MeterReads.API.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        void Remove(TEntity entity);
    }
}
