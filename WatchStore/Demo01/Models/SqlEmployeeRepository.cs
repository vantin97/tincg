using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SqlEmployeeRepository(AppDbContext context )
        {
            this.context = context;
        }
        public Employee Create(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;

        }

        public bool Delete(int Id)
        {
            var delEmp = context.Employees.Find(Id);
            if(delEmp != null)
            {
                context.Remove(delEmp);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            var editEmp = context.Employees.Attach(employee);
            editEmp.State = EntityState.Modified;
            context.SaveChanges();
            return employee;   
        }
        //public Employee Get(int? id)
        //{
        //    return context.Employees.Find(id);
        //}

        public Employee Get(int id)
        {
            return context.Employees.Find(id);
        }

        public IEnumerable<Employee> Gets()
        {
            return context.Employees;
        }
    }
}
