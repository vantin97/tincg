using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class Address
    {
        public int id { get; set; }
        public int idCountry { get; set; }
        public int idCity { get; set; }
        public int idWard { get; set; }
        public string addressDetail { get; set; }
        public int idUser { get; set; }
    }
}
