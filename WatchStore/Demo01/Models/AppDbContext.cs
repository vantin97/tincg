using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
             
        }
        public DbSet<Employee> Employees { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee()
        //        {
        //            Id = 1,
        //            FullName = "Trung Nguyen",
        //            Department = Dept.IT,
        //            Email = "trung@gmail.com",
        //            AvatarPath = "./images/anh trung.jpg"
        //        },
        //        new Employee()
        //        {
        //            Id = 2,
        //            FullName = "Quang Nguyễn",
        //            Department = Dept.HR,
        //            Email = "Quang@gmail.com",
        //            AvatarPath = "./images/quang.jpg"
        //        },
        //        new Employee()
        //        {
        //            Id = 3,
        //            FullName = "Trâm Nguyễn",
        //            Department = Dept.Payroll,
        //            Email = "tram@gmail.com",
        //            AvatarPath = "./images/trâm.png"
        //        },
        //        new Employee()
        //        {
        //            Id = 4,
        //            FullName = "Minh Nguyễn",
        //            Department = Dept.Sale,
        //            Email = "minh@gmail.com",
        //            AvatarPath = "./images/minh.jpg"
        //        },
        //        new Employee()
        //        {
        //            Id = 5,
        //            FullName = "Ghi Nguyễn",
        //            Department = Dept.Payroll,
        //            Email = "ghi@gmail.com",
        //            AvatarPath = "./images/chị ghi.jpg"
        //        }
        //    );
        //}
    }
}
