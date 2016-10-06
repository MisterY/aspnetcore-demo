using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApp.Data
{
    public class DrumsContext : DbContext
    {
        public DrumsContext() : base("name=DrumsConnection")
        {

        }

        public virtual DbSet<Drumset> Drumsets { get; set; }
    }
}