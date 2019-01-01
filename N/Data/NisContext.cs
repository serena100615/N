using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using N.Models;
using Microsoft.EntityFrameworkCore;

namespace N.Data
{
    public class NisContext : DbContext
    {
        public NisContext(DbContextOptions<NisContext> options) : base(options)
        {
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Memo>  Memos { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ad>().ToTable("Ad");
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<Memo>().ToTable("Memo");
            modelBuilder.Entity<Nurse>().ToTable("Nurse");
            modelBuilder.Entity<State>().ToTable("State");
            modelBuilder.Entity<Work>().ToTable("Work");
            modelBuilder.Entity<Shift>().ToTable("Shift");
        }
    }
}
