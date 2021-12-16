using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class TwitterContext : DbContext
    {
        public TwitterContext(DbContextOptions<TwitterContext> options) : base(options)
        {
        }

        public DbSet<Tweet> Tweets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tweet>().ToTable("Tweet");
        }
    }
}
