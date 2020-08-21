using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSmodul2.Models
{
    public interface IProductRepository
    {
        IEnumerable<Products> Gets();
        Products Get(string id);
        Products Create(Products products);
        Products Edit(Products products);
        bool Delete(string Id);
    }
}
