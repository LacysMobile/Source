using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LacysMobile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Lacy's Home Page";
            ViewBag.Header = "Welcome to Lacy's";
            return View();
        }

    }
}
