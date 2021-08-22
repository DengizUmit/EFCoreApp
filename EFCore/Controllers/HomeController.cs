using EFCore.Data.Contexts;
using EFCore.Data.Entities;
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

            //var entityEntry = udemyContext.Products.Add(new Data.Entities.Product
            //{
            //    Name = "Telephone",
            //    Price = 1480
            //});

            //udemyContext.Products.Update(new Data.Entities.Product
            //{
            //    Id = 1,
            //    Price = 2750
            //});

            //var updatedProduct = udemyContext.Products.Find(1);
            //updatedProduct.Price = 3300;
            //udemyContext.Products.Update(updatedProduct);

            //var deletedProduct = udemyContext.Products.FirstOrDefault(x => x.Id == 1);
            //udemyContext.Products.Remove(deletedProduct);

            Product product = new()
            {
                Price = 4000
            };
            udemyContext.Products.Add(product);

            udemyContext.SaveChanges();

            return View();
        }
    }
}
