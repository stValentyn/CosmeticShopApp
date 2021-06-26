using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmeticShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "О нашем магазине коротко:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Как нас найти";

            return View();
        }
    }
}