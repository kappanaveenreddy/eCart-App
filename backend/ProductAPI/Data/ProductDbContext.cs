using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        // Define DbSets for your entities
        // public DbSet<Product> Products { get; set; }
    }
}