using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM1.Models
{
    public partial class Catgorys
    {
        public int CatgoryId { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual Products Product { get; set; }
    }
}
