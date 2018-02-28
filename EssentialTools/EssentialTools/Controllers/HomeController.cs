using System.Web.Mvc;
using EssentialTools.Models;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;

        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        private Product[] products =
        {
            new Product {Name = "Kayak", Price = 275m},
            new Product {Name="Lifejacket", Price=48.95m},
            new Product {Name = "Soccer ball", Price = 19.50M},
            new Product {Name = "Corner flag", Price = 34.95M}
        };

        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(calc)
            {
                Products = products
            };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}