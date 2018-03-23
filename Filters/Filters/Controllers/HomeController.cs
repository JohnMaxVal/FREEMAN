using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Users ="admin")]
        public string Index()
        {
            return "This is an Index method on the Home Controller";
        }
        
        [GoogleAuth]
        [Authorize(Users = "bob@google.com")]
        public string List()
        {
            return "This is a List action on the Home Controller";
        }

        [HandleError(ExceptionType =typeof(ArgumentOutOfRangeException), View ="RangeError")]
        public string RangeTest(int id)
        {
            if(id > 100)
            {
                return string.Format("The id value is: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }
    }
}