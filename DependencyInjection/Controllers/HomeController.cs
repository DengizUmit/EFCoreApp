using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var total = _productService.GetTotal();
            return View();
        }
    }

    public interface IProductService
    {
        int GetTotal();
    }

    public class ProductManager : IProductService
    {
        public int GetTotal()
        {
            return 40;
        }
    }
}
