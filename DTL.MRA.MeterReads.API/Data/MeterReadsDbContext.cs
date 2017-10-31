using System;
using DTL.MRA.MeterReads.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DTL.MRA.MeterReads.API.Data
{
    public class MeterReadsDbContext : DbContext
    {
        public MeterReadsDbContext(DbContextOptions<MeterReadsDbContext> options) : base(options)
        {
        }

        public DbSet<MeterRead> MeterReads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
