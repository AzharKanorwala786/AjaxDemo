using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UI.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using Data;

namespace UI.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            Database.SetInitializer(new DBInitalize());
        }
    }
}