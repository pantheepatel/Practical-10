using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        [HandleError] // this will trigger only when an unhandled exception occurs, defined into filter config file.
        public ActionResult Index()
        {
            int num1 = 0;
            int num2 = 10 / num1; // comment this line to see the index view as no error will be thrown, else error page will be shown.
            return View();
        }
    }
}