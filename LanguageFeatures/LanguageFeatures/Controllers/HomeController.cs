using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {        
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            //Create a new product object
            Product myProduct = new Product();

            //Set the property value
            myProduct.Name = "Kayak";

            //Get the property
            string productName = myProduct.Name;

            //Generate the view
            return View("Result", (object)String.Format("Product name: {0}", productName));
        }

        public ViewResult CreateProduct()
        {
            //Create a new Product object
            Product myProduct = new Product();

            //Set the property values
            myProduct.ProductID = 100;
            myProduct.Name = "Kayak";
            myProduct.Description = "A boat for one person";
            myProduct.Price = 275m;
            myProduct.Category = "Watersports";

            return View("Result", (object)String.Format("Category: {0}", myProduct.Category));
        }
    }
}