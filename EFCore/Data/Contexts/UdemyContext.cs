﻿using EFCore.Data.Entities;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=UdemyEfCore; integrated security=true");
        }
    }
}
