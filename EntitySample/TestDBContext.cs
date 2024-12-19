using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySample
{
    public class TestDBContext : DbContext
    {
        public DbSet<ModelBook> Books { get; set; }

        public DbSet<ModelBook2> Book2s { get; set; }

        public DbSet<ModelBookCategory> BookCategorys { get; set; }

        public DbSet<ViewBook2> ViewBook2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=testdb;Trusted_Connection=True");
        }
    }
}
