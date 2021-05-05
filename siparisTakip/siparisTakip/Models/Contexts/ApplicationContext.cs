using siparisTakip.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace siparisTakip.Models.Contexts
{
    public class ApplicationContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Store>().HasMany(i => i.products).WithRequired().WillCascadeOnDelete(false);
            modelBuilder.Entity<Store>().HasMany(i => i.orders).WithRequired().WillCascadeOnDelete(false);
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserGroup> userGroups { get; set; }

    }
}