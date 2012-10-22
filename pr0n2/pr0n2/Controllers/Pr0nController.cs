using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pr0n2.Controllers
{
    public class Pr0nController : Controller
    {
        //
        // GET: /Pr0n/

        public ActionResult Index(int Number = 0)
        {
            ViewBag.Number = Number;
            return View();
        }

    }
}
