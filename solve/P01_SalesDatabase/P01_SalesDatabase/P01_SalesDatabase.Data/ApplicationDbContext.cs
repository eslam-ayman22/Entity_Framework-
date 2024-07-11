using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.P01_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Data
{
    internal class ApplicationDbContext :DbContext
    {
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Customer> customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Sales;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                 .HasMany(e => e.sales)
                 .WithOne(e => e.product)
                 .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.sales)
                .WithOne(e => e.customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.sales)
                .WithOne(e => e.Store)
                .HasForeignKey(e => e.StoreId);


            modelBuilder.Entity<Sale>()
           .Property(s => s.Date)
           .HasDefaultValueSql("20 - 11 - 2023");

           
        }
    }
}
