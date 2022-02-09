﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceBase.Domain.Entities;

namespace EcommerceBase.Domain
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext() : base("EcommerceDbContext")
        {
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<ProductStatus> ProductStatuses { get; set; }


       
    }
}
