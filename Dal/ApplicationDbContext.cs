using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Dal
{
    public sealed class ApplicationDbContext : IdentityDbContext
    {
        /// <summary>
        /// Streaming subscription table
        /// </summary>
        public DbSet<StreamingSubscription> StreamingSubscriptions { get; set; }
        
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }
    }
}
