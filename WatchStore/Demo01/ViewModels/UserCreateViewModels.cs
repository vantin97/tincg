﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.ViewModels
{
    public class UserCreateViewModels
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="password not match")]
        public string ConfirmPassword { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        [Display(Name ="Role")]
        public string RoleId { get; set; }
    }
}
