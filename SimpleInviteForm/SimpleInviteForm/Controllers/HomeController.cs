using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleInviteForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult InviteForm()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.HourJudge = Hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
    }
}