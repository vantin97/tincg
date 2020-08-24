using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            //employees = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        Id = 1, FullName = "Trung Nguyen", 
            //        Department = Dept.IT, 
            //        Email = "trung@gmail.com", 
            //        AvatarPath = "./images/anh trung.jpg"
            //    },
            //    new Employee()
            //    {
            //        Id = 2, FullName = "Quang Nguyễn",
            //        Department = Dept.HR,
            //        Email = "Quang@gmail.com",
            //        AvatarPath = "./images/quang.jpg"
            //    },
            //    new Employee()
            //    {
            //        Id = 3, FullName = "Trâm Nguyễn",
            //        Department = Dept.Payroll,
            //        Email = "tram@gmail.com",
            //        AvatarPath = "./images/trâm.png"
            //    },
            //    new Employee()
            //    {
            //        Id = 4, FullName = "Minh Nguyễn",
            //        Department = Dept.Sale,
            //        Email = "minh@gmail.com",
            //        AvatarPath = "./images/minh.jpg"
            //    },
            //    new Employee()
            //    {
            //        Id = 5, FullName = "Ghi Nguyễn",
            //        Department = Dept.Payroll,
            //        Email = "ghi@gmail.com",
            //        AvatarPath = "./images/chị ghi.jpg"
            //    },
            //};
        }

        public Employee Create(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            //Avt mặc định
            //employee.AvatarPath = 
            employees.Add(employee);
            return employee;
        }

        public bool Delete(int id)
        {
            var delEmp = Get(id);
            if(delEmp != null)
            {
                employees.Remove(delEmp);
                return true;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            var editEmp = Get(employee.Id);
            editEmp.FullName = employee.FullName;
            editEmp.Email = employee.Email;
            editEmp.Department = employee.Department;
            return editEmp;

        }

        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }        
    }
}
