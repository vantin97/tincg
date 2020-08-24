using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.ViewModels
{
    public class EditRoleViewModels : CreateRoleViewModels
    {
        public string RoleId { get; set; }
        
        
    }
}
