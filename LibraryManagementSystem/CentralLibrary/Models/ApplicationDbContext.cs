using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CentralLibrary.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> BookTable { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<LibraryStaff> LibraryStaff { get; set; }
        public DbSet<Publication> Publication { get; set; }
        public DbSet<LibraryCard> LibraryCard { get; set; }
        public DbSet<Fine> Fine { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<AdminLogin> AdminLogin { get; set; }

    }

}
