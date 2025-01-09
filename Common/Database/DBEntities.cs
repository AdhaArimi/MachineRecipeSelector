using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json.Serialization;

namespace Recipe.Common.Database
{
    public class DBEntities : DbContext
    {
        private static bool _created = false;

        public DBEntities()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source = " + Directory.GetCurrentDirectory() + "\\Data.db";
            optionsBuilder.UseSqlite(connectionString);
        }
        public virtual DbSet<Recipe> Recipes { get; set; }
    }
}
