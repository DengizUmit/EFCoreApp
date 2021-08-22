using EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Data.Contexts
{
    public class UdemyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<SaleHistory> SaleHistories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=UdemyEfCore; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many To Many
            modelBuilder.Entity<Category>().
                HasMany(x => x.ProductCategories).WithOne(x => x.Category).
                HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<Product>().
                HasMany(x => x.ProductCategories).WithOne(x => x.Product).
                HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProductId });

            // One To One
            modelBuilder.Entity<Product>().
                HasOne(x => x.ProductDetail).WithOne(x => x.Product).
                HasForeignKey<ProductDetail>(x => x.ProductId);

            // One To Many || Many To One
            //modelBuilder.Entity<Product>().
            //    HasMany(x => x.SaleHistories).WithOne(x => x.Product).
            //    HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<SaleHistory>().
                HasOne(x => x.Product).WithMany(x => x.SaleHistories).
                HasForeignKey(x => x.ProductId);

            //modelBuilder.Entity<Customer>().HasNoKey();
            modelBuilder.Entity<Customer>().HasKey(x => x.Number);
            //modelBuilder.Entity<Customer>().HasKey(x => new { x.Number, x.Name });

            //modelBuilder.Entity<Category>().ToTable(name: "Categories", schema: "dbo");
            
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product_name");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("'product name not found'");
            modelBuilder.Entity<Product>().Property(x => x.CreatedTime).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("product_id");
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnName("product_price");
            modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 3);

            base.OnModelCreating(modelBuilder);
        }
    }
} 
