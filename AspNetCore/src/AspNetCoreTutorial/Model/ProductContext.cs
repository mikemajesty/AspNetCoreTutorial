using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTutorial.Model
{
    public class ProductContext
    {
        public DbSet<Category> Category { get; set; }

        public DbSet<Products> Product { get; set; }
    }
}
