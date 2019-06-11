using CoreWiki.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreWiki.Providers.Data.EF
{
    public class WikiCoreDbContext : DbContext
    {
        public WikiCoreDbContext(DbContextOptions<WikiCoreDbContext> options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}