using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Model
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string SeoUrl { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
