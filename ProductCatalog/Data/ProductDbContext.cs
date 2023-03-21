using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductCatalog.Models;

namespace ProductCatalog.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

       
          protected override void OnModelCreating(ModelBuilder builder)
        {
           
            base.OnModelCreating(builder);

                   }

    }
}
