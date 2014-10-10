using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RPSWebApp.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RPSWebApp.DAL
{
    public class RPSContext : DbContext
    {
       
        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}