using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCard.Domain.Entities
{
    public class Nevigation
    {
            public int Id { get; set; }
            public string? label { get; set; }
            public string? displayTextEN { get; set; }
            public string? displayTextAR { get; set; }
            public string? color { get; set; }
            public string? route { get; set; }
            public string? icon { get; set; }
        
    }
}
