using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAndRegister.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public string test(string q)
        {
            return q;
        }
        [HttpPost]
        public string about(FormCollection form)
        {
            return Request.Form["ContactName"];
        }

    }
}