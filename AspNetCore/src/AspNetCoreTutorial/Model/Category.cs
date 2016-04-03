using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTutorial.Model
{
    public class Category
    {
        public string CatergoryId { get; set; }
        public string DisplayName { get; set; }
        public List<Products> Products { get; set; }
    }
}
