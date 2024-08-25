using Bloggie.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Data
{
    public class myDbContext : DbContext
    {
        public myDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BlogPost> Posts { get; set; }
        public DbSet<Tag> tags { get; set; }
    }
}
