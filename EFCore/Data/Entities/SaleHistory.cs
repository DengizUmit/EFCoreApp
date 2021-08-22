using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Data.Entities
{
    public class SaleHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        //Navigation Property
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
