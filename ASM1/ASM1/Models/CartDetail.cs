using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM1.Models
{
    public partial class CartDetail
    {
        public int CartDetailId { get; set; }
        public int? CartId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductAmount { get; set; }
        public int? ProductPrice { get; set; }
        public int? TotalPrice { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Products Product { get; set; }
    }
}
