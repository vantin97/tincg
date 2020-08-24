using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.ViewModels
{
    public class RegisterViewModels
    {
        [Required(ErrorMessage ="Email không hợp lệ")]
        [EmailAddress]
        [Display(Name = "Nhập Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Mật khẩu chưa đủ mạnh ")]
        [Display(Name ="Hãy nhập mật khẩu: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Mật khẩu không khớp")]
        [Display(Name = "Nhập lạu mật khẩu: ")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Mật khẩu không trùng khớp!!!")]
        public string ConfirmPassword { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        //public string Description { get; set; }
        //public int Price { get; set; }
    }
}
