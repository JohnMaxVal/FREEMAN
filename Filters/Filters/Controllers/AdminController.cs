using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Create()
        {
            return View();
        }

        public ViewResult Edit()
        {
            return View();
        }
    }
}