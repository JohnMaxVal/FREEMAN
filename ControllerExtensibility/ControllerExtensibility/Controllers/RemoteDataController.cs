﻿using System.Web.Mvc;
using ControllerExtensibility.Models;
using System.Threading.Tasks;
using System.Threading;

namespace ControllerExtensibility.Controllers
{
    public class RemoteDataController : Controller
    {
        public async Task<ActionResult> Data()
        {
            RemoteService service = new RemoteService();
            string data = await Task<string>.Factory.StartNew(() =>
            {
                return new RemoteService().GetRemoteData();
            });
            return View((object)data);
        }

        public async Task<ActionResult> ConsumeAsyncMethod()
        {
            string data = await new RemoteService().GetRemoteDataAsync();
            return View("Data", (object)data);
        }
    }
}