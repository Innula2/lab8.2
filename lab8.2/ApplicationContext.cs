using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace lab8._2
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
        }
    }
}
