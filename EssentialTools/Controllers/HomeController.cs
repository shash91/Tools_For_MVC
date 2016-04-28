using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private Product[] products =
    {

            new Product {Name="Kayak",Category="Watersports",Price=275M },
            new Product {Name="LifeJacket",Category="Watersports",Price=48.95M },
            new Product {Name="Soccer Ball",Category="Soccer",Price=19.50M },
            new Product {Name="corner Flag",Category="Soccer",Price=34.95M }
        };
        private IValueCalculator calc;
        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
           

            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalvalue = cart.CalculateProductTotal();

            return View(totalvalue);
        }
    }
}