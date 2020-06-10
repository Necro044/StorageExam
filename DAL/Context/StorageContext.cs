using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DAL.Entities.IdentityModel;
using DAL.Entities;

namespace DAL.Context
{
    class StorageContext : IdentityDbContext<User>
    {
        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options) { }
        public DbSet<Ware> Wares { get; set; }
        public DbSet<FoodProduct> Products { get; set; }
        public DbSet<Storage> storages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
