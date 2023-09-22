using Microsoft.EntityFrameworkCore;
using UnitTestApi.Entity;

namespace UnitTestApi.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>options):base(options) 
        {
        }
        public DbSet<Product> Products { get; set; }
    }

}
