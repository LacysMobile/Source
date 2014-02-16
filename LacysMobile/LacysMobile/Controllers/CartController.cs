using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LacysMobile.Controllers
{
    public class CartController : Controller
    {
        
        public ActionResult Checkout()
        {
            ViewBag.Header = "Checkout";
            return View();
        }

    }
}
