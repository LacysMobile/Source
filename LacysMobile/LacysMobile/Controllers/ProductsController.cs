using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LacysMobile.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult GetProductsByType(string itemType)
        {
            string headerName = "";
            switch (itemType)
            {
                case "WomenDress":
                    headerName = "Women's Dresses";
                    break;
                case "WomenCoats":
                    headerName = "Women's Coats";
                    break;
                case "MenPants":
                    headerName = "Men's Pants";
                    break;
                default: // "MenCoats"
                    headerName = "Men's Coats";
                    break;
            }
            ViewBag.Header = headerName;
            return View();
        }

    }
}
