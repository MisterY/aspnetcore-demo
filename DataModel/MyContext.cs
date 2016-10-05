using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class MyContext : DbContext
    {
        public DbSet<Drumset> Set { get; set; }
        public DbSet<Cymbal> Cymbal { get; set; }
        public DbSet<Tom> Tom { get; set; }
        public DbSet<HiHat> HiHat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=../../../../data/database.sqlite");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cymbal>().HasKey(x => x.Name);

            modelBuilder.Entity<Drumset>().HasKey(x => x.Name);
            modelBuilder.Entity<Drumset>().HasOne<HiHat>();

            modelBuilder.Entity<HiHat>().HasKey(x => x.Name);

            modelBuilder.Entity<Tom>().HasKey(x => x.Name);
        }
    }
}
