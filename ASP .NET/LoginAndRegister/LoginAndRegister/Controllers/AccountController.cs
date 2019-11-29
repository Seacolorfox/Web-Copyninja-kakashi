using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LoginAndRegister.Models;

namespace LoginAndRegister.Controllers
{
    public class AccountController : Controller
    {
        private DBContext db = new DBContext();
        // GET: Account/CheckUser
        [HttpGet]
        public JsonResult CheckUser(string username)
        {
            var exists = db.userInfo.Where(a => a.userName == username).Count() != 0;
            return Json(exists, JsonRequestBehavior.AllowGet);
        }
        // GET: Account
        public ActionResult Index()
        {
            return View(db.userInfo.ToList());
        }

        // GET: Account/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfo userInfo = db.userInfo.Find(id);
            if (userInfo == null)
            {
                return HttpNotFound();
            }
            return View(userInfo);
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,userName,userPwd,userEmail,userRank,RegisterTime")] UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                db.userInfo.Add(userInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userInfo);
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfo userInfo = db.userInfo.Find(id);
            if (userInfo == null)
            {
                return HttpNotFound();
            }
            return View(userInfo);
        }

        // POST: Account/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,userName,userPwd,userEmail,userRank,RegisterTime")] UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userInfo);
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfo userInfo = db.userInfo.Find(id);
            if (userInfo == null)
            {
                return HttpNotFound();
            }
            return View(userInfo);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserInfo userInfo = db.userInfo.Find(id);
            db.userInfo.Remove(userInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult test()
        {
            return View();
        }
        public ActionResult Register(UserInfo userInfo)
        {
            string checkPwd = Request["ChkUserPwd"].ToString();
                 string vCode = Request["vCode"].ToString().ToLower();
            
    if (string.IsNullOrEmpty(checkPwd))
                     {
                         ModelState.AddModelError("ChkUserPwd", "确认密码不能为空");
                     }
                 else
                 {
                     if (Md5Hash(checkPwd) != Md5Hash(userInfo.userPwd))
                             {
                                  ModelState.AddModelError("PwdRepeatError", "确认密码不正确");
                             }
                     }

            if (!ChkValidateCode(vCode))
                     {
                          ModelState.AddModelError("vCode", "验证码不正确");
                   }
            
   bool isUserExists = db.userInfo.Where(a => a.userName == userInfo.userName).Count() != 0;
                 bool isEmailExists = db.userInfo.Where(a => a.userEmail == userInfo.userEmail).Count() != 0;
            
     if (isUserExists) ModelState.AddModelError("UserName", "用户名已被占用");
               if (isEmailExists) ModelState.AddModelError("UserEmail", "邮箱已被注册");
            

     if (!ModelState.IsValid)
                    {
                        return View(userInfo);
                     }
                 userInfo.RegisterTime = DateTime.Now;
              //   userInfo.userPwd = Md5Hash(userInfo.userPwd);
                try
    {
                       db.userInfo.Add(userInfo);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                 catch (DbEntityValidationException dbEx)
    {
                         foreach (var validationErrors in dbEx.EntityValidationErrors)
                             {
                                 foreach (var validationError in validationErrors.ValidationErrors)
                                   {
                                    System.Diagnostics.Trace.TraceInformation("Property: {0} Error: {1}",
                                    validationError.PropertyName,
                                   validationError.ErrorMessage);
                                    }
                             }
                        throw;
                     }
        }

        private bool ChkValidateCode(string vCode)
        {
            throw new NotImplementedException();
        }

        private object Md5Hash(string checkPwd)
        {
            throw new NotImplementedException();
        }
    }
}
