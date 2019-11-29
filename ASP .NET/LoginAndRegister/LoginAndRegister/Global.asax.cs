using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LoginAndRegister.Models;

namespace LoginAndRegister
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public class DBinit:DropCreateDatabaseIfModelChanges<DBContext>
        {
            protected override void Seed(DBContext context)
            {
                context.userInfo.Add(new UserInfo
                {
                    userName = "troy",
                    userPwd = "123456",
                    userEmail = "123@qq.com",
                    userRank = 0,
                    RegisterTime = DateTime.Now
                });
                base.Seed(context);
            }
        }
        protected void Application_Start()
        {
            Database.SetInitializer(new DBinit());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
