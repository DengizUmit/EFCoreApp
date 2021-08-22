using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //Navigation Property
        public List<SaleHistory> SaleHistories { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
