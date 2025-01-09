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
        //Database Configure
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DatabaseCfg cfg = new DatabaseCfg();
            //if (File.Exists(Directory.GetCurrentDirectory() + "\\cfg.json"))
            //{
            //    using (var r = new StreamReader(Directory.GetCurrentDirectory() + "\\cfg.json"))
            //    {
            //        var json = r.ReadToEnd();
            //        cfg = JsonConvert.DeserializeObject<DatabaseCfg>(json);
            //    }
            //}
            var connectionString = "Data Source = " + Directory.GetCurrentDirectory() + "\\Data.db";
            optionsBuilder.UseSqlite(connectionString);
        }
        public virtual DbSet<Recipe> Recipes { get; set; }
    }
}
