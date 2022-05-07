using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rankfire.Data
{
    public class Product
    {
        [Key]
        public Guid GUID_Product { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
