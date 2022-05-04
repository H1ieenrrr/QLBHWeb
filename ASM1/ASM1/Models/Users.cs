using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM1.Models
{
    public partial class Users
    {
        public Users()
        {
            Cart = new HashSet<Cart>();
        }
        [Key]

        public int UsersId { get; set; }

        [Display(Name = "Tên Đăng Nhập")]
        [Required(ErrorMessage ="Bạn phải nhập tài khoản")]
        public string UsersName { get; set; }
        public string UsersEmail { get; set; }

        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Bạn phải nhập mật khẩu")]
        public string UsersPassword { get; set; }
        public string UsersPhone { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }

        
    }
}
