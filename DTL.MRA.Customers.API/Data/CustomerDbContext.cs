using System;
using DTL.MRA.Customers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DTL.MRA.Customers.API.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
