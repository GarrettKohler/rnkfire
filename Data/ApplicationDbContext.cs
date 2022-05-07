using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using rankfire.Data;

namespace rankfire.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<rankfire.Data.ProductReview> ProductReview { get; set; }
        public DbSet<rankfire.Data.RetailProduct> RetailProduct { get; set; }
        public DbSet<rankfire.Data.Product> Product { get; set; }
        public DbSet<rankfire.Data.CompLab> CompLab { get; set; }
        public DbSet<rankfire.Data.Producer> Producer { get; set; }
        public DbSet<rankfire.Data.Retailer> Retailer { get; set; }
    }
}
