using Microsoft.EntityFrameworkCore;

namespace gNight.Models
{
    public class gNightContext : DbContext
    {
        public gNightContext(DbContextOptions<gNightContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}