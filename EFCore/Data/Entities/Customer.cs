using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Data.Entities
{
    public class Customer
    {
        //[Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
