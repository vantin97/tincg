using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    interface IGateRepository
    {
        IEnumerable<Gate> Gets();
        Gate Get(int id);
        Gate Create(Gate gate);
        Gate Edit(Gate gate);
        bool IsDeleted(int id);
        bool IsPublished(int id);
    }
}
