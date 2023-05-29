using Microsoft.EntityFrameworkCore;
using RazorPagesAK.Entities;

namespace RazorPagesAK.Model
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
