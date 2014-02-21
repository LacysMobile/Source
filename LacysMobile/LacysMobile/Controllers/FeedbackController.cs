using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LacysMobile.Controllers
{
    public class FeedbackController : Controller
    {
        
        public ActionResult FeedbackForm()
        {
            ViewBag.Header = "Feedback Form";
            return View();
        }

    }
}
