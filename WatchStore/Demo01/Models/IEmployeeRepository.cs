using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
        Employee Get(int id);
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        bool Delete(int Id);
        //Employee Get(int? id);
    }
}
