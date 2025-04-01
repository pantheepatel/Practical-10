using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 300)]
        public ActionResult Index()
        {
            ViewBag.TimeNow_ = DateTime.Now.ToString();
            return View();
        }
    }
}