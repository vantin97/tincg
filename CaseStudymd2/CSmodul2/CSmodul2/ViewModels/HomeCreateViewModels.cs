using CSmodul2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSmodul2.ViewModels
{
    public class HomeCreateViewModels
    {
        [Required(ErrorMessage = "không được bỏ trống")]
        [Display(Name = "Nhập tên bài viết")]
        [MaxLength(20, ErrorMessage = "Giới hạn 20 ký tự")]
        public string NameProduct { get; set; }
        [Required(ErrorMessage = "không được bỏ trống")]
        [Display(Name = "Nhập Mô tả")]        
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "không được bỏ trống")]
        [Display(Name = "Nhập nội dung bài ")]
        public string Content { get; set; }
        [Required(ErrorMessage = "không được bỏ trống")]
        [Display(Name = "Nhập tác giả")]
        public string Author { get; set; }
        [Required(ErrorMessage = "không được bỏ trống")]
        [Display(Name = "Nhập kiểu")]
        public Types ProTpye { get; set; }
        //public IFormFile Avatar { get; set; }
    }
}
