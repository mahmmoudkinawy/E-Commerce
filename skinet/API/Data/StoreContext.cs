﻿using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Product one"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Product two"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Product three"
            });

        }
    }
}
