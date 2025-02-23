using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Revenue_Calculations.Model
{
    public class RevenueDbContext : DbContext
    {
        public RevenueDbContext(DbContextOptions<RevenueDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
