using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rankfire.Data
{
    public class ProductReview
    {
        [Key]
        public Guid GUID_ProductReview { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewBody { get; set; }
        public int QualityScore { get; set; }
        public int ValueScore { get; set; }        
    }
}


