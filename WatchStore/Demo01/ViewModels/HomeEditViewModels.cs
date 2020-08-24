using Demo01.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.ViewModels
{
    public class HomeEditViewModels : HomeCreateViewModels
    {
        public int Id { get; set; }
        public string AvatarPath { get; set; }        
    }
}
