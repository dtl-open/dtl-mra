using System;
using DTL.MRA.Data.Domains;
using Microsoft.EntityFrameworkCore;

namespace DTL.MRA.Data
{
    public class MraDbContext : DbContext
    {
        public MraDbContext(DbContextOptions<MraDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Meter> Meters { get; set; }
        public DbSet<MeterRead> MeterReads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
