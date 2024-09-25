using Microsoft.EntityFrameworkCore;
using Mysqldemo.Models;
namespace Mysqldemo.Data

{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }


    }
}
