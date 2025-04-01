using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            int num1 = 0;
            int num2 = 10 / num1;
            return View();
        }
    }
}