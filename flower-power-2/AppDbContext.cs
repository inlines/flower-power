using flower_power_2.Models;
using Microsoft.EntityFrameworkCore;

namespace flower_power_2
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Flower> Flowers { get; set; }
    }
}
