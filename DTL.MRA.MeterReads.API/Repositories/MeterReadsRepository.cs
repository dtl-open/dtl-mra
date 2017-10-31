using System;
using DTL.MRA.MeterReads.API.Data;
using DTL.MRA.MeterReads.API.Models;

namespace DTL.MRA.MeterReads.API.Repositories
{
    public class MeterReadsRepository : Repository<MeterRead>, IMeterReadsRepository
    {
        public MeterReadsRepository(MeterReadsDbContext context) : base(context)
        {
        }

        public MeterReadsDbContext MeterReadsDbContext
        {
            get { return Context as MeterReadsDbContext; }
        }
    }
}
