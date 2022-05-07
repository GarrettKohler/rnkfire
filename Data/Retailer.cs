using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace rankfire.Data
{
    public class Retailer
    {
        [Key]
        public Guid GUID_Retailer { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LicenseNumber { get; set; }
    }
}
