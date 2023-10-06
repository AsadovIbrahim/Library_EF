using Library_EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF.Contexts
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IBRAHIM\\;Database=Library2;SQLEXPRESS;Integrated Security=True;");  
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<BookTypes> BookTypes { get; set; }
        public DbSet<Operations> Operations { get; set; }
        public DbSet<Students> Students { get; set; }
    }
}
