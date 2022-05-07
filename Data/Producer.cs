using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace rankfire.Data
{
    public class Producer
    {
        [Key]
        public Guid GUID_Producer { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LicenseNumber { get; set; }
    }
}
