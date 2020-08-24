using Demo01.Models;
using Demo01.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IEmployeeRepository employeeRepository, 
                                IHostingEnvironment hostingEnvironment)
        {
            this.employeeRepository = employeeRepository;
            this.hostingEnvironment = hostingEnvironment;
        }
        [AllowAnonymous]
        public ViewResult Index()
        {
            ViewData["employees"] = employeeRepository.Gets();

            var employees = employeeRepository.Gets();
            return View(employees);
        }
        public ViewResult Details(int? id)
        {
            //var employee = employeeRepository.Get(id.Value);
            //if (employee != null)
            //{
            //    return View("~/Views/Error/EmployeeNotFound.cshtml", id.Value);
            //}
            //var detailsViewModel = new HomeDetailsViewModels()
            //{
            //    Employee = employeeRepository.Get(id ?? 1),
            //    TitleName = "Employee Details"
            //};
            var detailsViewModel = new HomeDetailsViewModels()
            {
                Employee = employeeRepository.Get(id.Value),
                TitleName = "Details"
            };
            return View(detailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModels model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Department = model.Department,
                    Price = model.Price,
                    Description = model.Description
                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                }
                employee.AvatarPath = fileName; 
                var newEmp = employeeRepository.Create(employee);
                return RedirectToAction("Details", new { id = newEmp.Id });
            }
            return View();
        }
        public ViewResult Edit(int id)
        {
            var employee = employeeRepository.Get(id);
            if (employee == null)
            {
                return View("~/Views/Error/EmployeeNotFound.cshtml", id);
            }
            var editEmp = new HomeEditViewModels()
            {
                AvatarPath = employee.AvatarPath,
                FullName = employee.FullName,
                Email = employee.Email,
                Department = employee.Department,
                Id = employee.Id,
                Price = employee.Price,
                Description = employee.Description
            };
            return View(editEmp);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModels model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Department = model.Department,
                    Id = model.Id,
                    AvatarPath = model.AvatarPath,
                    Price = model.Price,
                    Description = model.Description
                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                    employee.AvatarPath = fileName;
                }                
                var editEmp = employeeRepository.Edit(employee);
                if (editEmp != null)
                {
                    return RedirectToAction("Details", new { id = employee.Id });
                }                
            }
            return View();
        }
        
        public IActionResult Delete(int id)
        {
            if (employeeRepository.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}