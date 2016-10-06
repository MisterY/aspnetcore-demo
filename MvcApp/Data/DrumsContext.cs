using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcApp.Data
{
    public class DrumsContext : DbContext
    {
        public DrumsContext() : base("name=DrumsConnection")
        {

        }

        public virtual DbSet<Drumset> Drumset { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}