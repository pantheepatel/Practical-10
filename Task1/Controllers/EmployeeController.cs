using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Controllers
{
    [RoutePrefix("Employee")]
    public class EmployeeController : Controller
    {
        [Route("{name?}")]
        [HttpGet]
        // GET: Employee
        public ActionResult Index(string name = "Panthee")
        {
            ViewBag.Name = name;
            return View();
        }
    }
}