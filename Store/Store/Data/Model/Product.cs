using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Model
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public  int CategoryId { get; set; }
        public  Category Category { get; set; }
    }
}
