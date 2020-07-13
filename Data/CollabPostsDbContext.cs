using Microsoft.EntityFrameworkCore;
using collabnetwork.Models;

namespace collabnetwork.Data
{
    public class CollabPostsDbContext : DbContext
    {
        public CollabPostsDbContext(DbContextOptions<CollabPostsDbContext> options) : base(options)
        {
        }
        public DbSet<CollabPost> CollabPosts {get;set;}
    }
}