using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rankfire.Data
{
    public class ScanQR
    {
            [Display(Name = "QRCode Text")]
            public string QRCodeText { get; set; }
            [Display(Name = "QRCode Image")]
            public string QRCodeImagePath { get; set; }
    }
}
