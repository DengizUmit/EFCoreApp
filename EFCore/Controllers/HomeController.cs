using EFCore.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UdemyContext udemyContext = new();

            var entityEntry = udemyContext.Products.Add(new Data.Entities.Product
            {
                Name = "Telephone",
                Price = 1480
            });

            udemyContext.SaveChanges();

            return View();
        }
    }
}
