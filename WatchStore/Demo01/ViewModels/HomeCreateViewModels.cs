using Demo01.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.ViewModels
{
    public class HomeCreateViewModels
    {
        [Required(ErrorMessage = "Hãy nhập tên sản phẩm")]
        [Display(Name = "Nhập tên sản phẩm")]
        [MaxLength(100, ErrorMessage = "Giới hạn 100 ký tự")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Mời nhập Email")]
        [Display(Name = "Nhập Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                            ErrorMessage = "Email không đúng quy định(Ví dụ abc@gmail.com)")]
        public string Email { get; set; }
        [Display(Name = "Loại sản phẩm")]
        [Required(ErrorMessage = "Hãy chọn 1")]
        public Dept? Department { get; set; }
        public  IFormFile Avatar { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
