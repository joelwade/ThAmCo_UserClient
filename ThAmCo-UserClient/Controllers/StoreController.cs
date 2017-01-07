using Dtos;
using GatewayRepo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThAmCo_UserClient.Controllers
{
    public class StoreController : Controller
    {
        IGatewayRepo repo;

        public StoreController(IGatewayRepo repo)
        {
            this.repo = repo;
        }

        public StoreController()
        {
            this.repo = new ConcGatewayRepo();
        }

        // GET: Store
        public ActionResult Index()
        {
            var page = repo.GetStore();

            return View(page);
        }
    }
}