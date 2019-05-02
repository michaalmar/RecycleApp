using RecycleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;


namespace RecycleApp.DAL
{
    public class DataContex : DbContext
    {
        public DataContex() : base("RecycleDB")
        { 
        }

        public DbSet<Trash> Trashes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //ustawia nazwy tabel jako pojedyncze
        }
    }
}