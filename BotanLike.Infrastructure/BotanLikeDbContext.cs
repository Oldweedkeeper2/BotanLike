using BotanLike.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BotanLike.Infrastructure
{
    public class BotanLikeDbContext : DbContext
    {
        public BotanLikeDbContext(DbContextOptions<BotanLikeDbContext> context) : base(context) //base передаёт настройки в DbContext
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        public DbSet<User> User { get; set; }
    }
}
