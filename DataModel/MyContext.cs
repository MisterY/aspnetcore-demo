using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class MyContext : DbContext
    {
        public DbSet<Drumset> Sets { get; set; }
        public DbSet<Cymbal> Cymbals { get; set; }
        public DbSet<Tom> Toms { get; set; }
        public DbSet<HiHat> HiHats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.use

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Drumset>().HasKey(x => x.Name);
            modelBuilder.Entity<Drumset>().HasOne<HiHat>();
        }
    }
}
