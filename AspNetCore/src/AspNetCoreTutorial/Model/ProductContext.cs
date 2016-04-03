using Microsoft.Data.Entity;

namespace AspNetCoreTutorial.Model
{
    public class ProductContext
    {
        public DbSet<Category> Category { get; set; }

        public DbSet<Products> Product { get; set; }
    }
}
