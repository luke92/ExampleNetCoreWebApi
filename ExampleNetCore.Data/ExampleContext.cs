using ExampleNetCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExampleNetCore.Data
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExampleTable>().ToTable("Example", "dbo");
        }
        //entities
        public DbSet<ExampleTable> Examples { get; set; }
    }
}
