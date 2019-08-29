using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAndRegister.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登陆前...";
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {
            string email = formCollection["inputEmail3"];
            string password = formCollection["inputPassword3"];

            ViewBag.LoginState =email+ "登陆后...";
            return View();
        }
    }

}