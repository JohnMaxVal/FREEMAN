using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    public class CustomController : Controller
    {
        [SimpleMessage(Message = "A")]
        public string Index()
        {
            return "This is the Custom controller";
        }

        [CustomOverrideActionFilters]
        [SimpleMessage(Message ="B")]
        public string OtherAction()
        {
            return "This is the Other Action in the Custom controller";
        }
    }
}