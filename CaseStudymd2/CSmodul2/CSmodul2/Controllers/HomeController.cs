using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSmodul2.Models;
using Microsoft.AspNetCore.Routing;
using CSmodul2.ViewModels;
using Microsoft.AspNetCore.Hosting;

namespace CSmodul2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IProductRepository productRepository,
                                IHostingEnvironment hostingEnvironment)
        {
            this.productRepository = productRepository;
            this.hostingEnvironment = hostingEnvironment;
        }
        public ActionResult Index()
        {
            //IEnumerable<Products> products = productRepository.Gets();
            //return View(products);
            ViewData["Products"] = productRepository.Gets();
            var product = productRepository.Gets();
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details(string id)
        {
            var product = productRepository.Get(id);
            return View(product);
        }
        public IActionResult Managerment()
        {
            IEnumerable<Products> products = productRepository.Gets();
            return View(products);
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
                var products = new Products()
                {
                    NameProduct = model.NameProduct,
                    ShortDescription = model.ShortDescription,
                    Author = model.Author,
                    Content = model.Content,
                    ProType = model.ProTpye 
                    //Email = model.Email,
                    //Department = model.Department
                };
            }
            return View();
        }
    }
}
