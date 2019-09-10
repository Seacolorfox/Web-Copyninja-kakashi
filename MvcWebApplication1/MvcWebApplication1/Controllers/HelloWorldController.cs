using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index() => "Hello World!!";
        //public string Welcome() => "Welcome!!";

        public string Welcome(string name, int numTimes = 1) => HttpUtility.HtmlEncode("Welcome" + name + string.Format(",第{0}次来到ASP.NET MVC 的世界！", numTimes));
        public ActionResult List() => View();

        public ActionResult WelcomeName(string name,int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}