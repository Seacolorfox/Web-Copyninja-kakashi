using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleInviteForm.Models;

namespace SimpleInviteForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Hello() => "Hello ASP.NET MVC!";
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
        [HttpGet]
        public ActionResult RvspForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RvspForm(GuestResponse guestResponse)
        {
           // bool willAttend = guestResponse["inputWillAttend"];
            return View("Thanks", guestResponse);
        }
        public ActionResult Thanks() => View();
    }
}