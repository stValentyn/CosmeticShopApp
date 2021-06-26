using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmeticShop.Controllers
{
    public class TypeCosController : Controller
    {
        // GET: TypeCos
        public ActionResult Care()
        {
            return View();
        }
        public ActionResult MakeUp()
        {
            return View();
        }
    }
}