using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSmodul2.Models
{
    public class Products
    {
        public string ProductId { get; set; }
        public string NameProduct { get; set; }
        public Types ProType { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
