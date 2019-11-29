using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginAndRegister.Models
{
    public class DBContext:DbContext
    {
        public DBContext() : base("connection") { }
        public DbSet<UserInfo> userInfo { get; set; }

    }
}