using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rankfire.Data
{
    public class RetailProduct
    {
        [Key]
        public Guid GUID_RetailProduct { get; set; }
        public string Name { get; set; }
        public string ProductDescription { get; set; }
        public string ProductType { get; set; }
        public string ProductUOM { get; set; }
        public float Quantity { get; set; }
        public float RetailPrice { get; set; }
        public float ProductCost { get; set; }
        public string ImagePath { get; set; }


    }
}
