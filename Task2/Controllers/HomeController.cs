using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //ContentResult
        public ContentResult ContentResultDemo()
        {
            return Content("Hello! from content result Demo");
        }

        //FileResult
        public FileResult FileResultDemo()
        {
            string filePath = Server.MapPath("~/App_Data/SampleText.txt");

            if (System.IO.File.Exists(filePath))
            {
                return File(filePath, "text/plain", "SampleText.txt");
            }
            else
            {
                return null;
            }
        }

        //EmptyResult
        public EmptyResult EmptyResultDemo()
        {
            return new EmptyResult();
        }

        //JavaScriptResult - this will not work as expected because
        public JavaScriptResult JavaScriptResultDemo()
        {
            return JavaScript("alert('Hello this is Task2 Demo')");
        }

        //JsonResult
        public JsonResult JsonResultDemo()
        {
            var data = new { Name = "Panthee", Age = 20, City = "Ahmedabad" };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //RedirectResult
        public RedirectResult RedirectResultDemo()
        {
            return Redirect("https://www.bing.com/");
        }

        //RedirectToRouteResult
        public RedirectToRouteResult RedirectToRouteResultDemo()
        {
            return RedirectToAction("ContentResultDemo");
        }

        //ViewResult
        public ViewResult ViewResultDemo()
        {
            return View();
        }

        //This is parent class from this we can call any action result
        //ActionResult
        public ActionResult ActionResultDemo()
        {
            return Content("Hello this is ActionResult Demo");
        }
    }
}