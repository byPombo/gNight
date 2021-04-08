using Microsoft.EntityFrameworkCore;
using gNight.Models;

namespace gNight.Models
{
    public class gNightContext : DbContext
    {
        public gNightContext(DbContextOptions<gNightContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<gNight.Models.User> User { get; set; }
    }
}