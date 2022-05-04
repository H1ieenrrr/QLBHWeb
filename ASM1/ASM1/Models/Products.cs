using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM1.Models
{
    public partial class Products
    {
        public Products()
        {
            CartDetail = new HashSet<CartDetail>();
            Catgorys = new HashSet<Catgorys>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime? ProductDate { get; set; }
        public string ProductImage { get; set; }
        public int? ProductAmount { get; set; }
        public int? CatgoryId { get; set; }
        public decimal? ProductPrice { get; set; }

        public virtual ICollection<CartDetail> CartDetail { get; set; }
        public virtual ICollection<Catgorys> Catgorys { get; set; }

        public class Item
        {
            public Products Products { get; set; }
            public int? ProductAmount { get; set; }
            public string ProductImage { get; set; }
        }
    }
    public class ProductModels
    {
        private QLBGiayContext db = new QLBGiayContext();
        public List<Products> FindAll()
        {
            
            var a = db.Products.ToList();
            return a;
        }
        public Products Find(int id)
        {
            var a = db.Products.Find(id);
            return a;
        }
    }
}
