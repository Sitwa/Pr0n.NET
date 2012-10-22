using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pr0n2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Zmodyfikuj ten szablon, aby szybko uruchomić swoją aplikację platformy ASP.NET MVC.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Twoja strona z opisem aplikacji.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Strona z Twoimi danymi kontaktowymi.";

            return View();
        }
    }
}
