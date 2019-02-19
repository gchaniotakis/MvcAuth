using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAuth.Security;

namespace MvcAuth.Controllers
{
    public class SecureController : Controller
    {
        
        [AppAuthorize(Roles = "users,admin,developers,owner")]
        public ActionResult Index()
        {
            return View();
        }
        [AppAuthorize (Roles = "developers")]
        public ActionResult DevelopersOnly()
        {
            return View();
        }
    }
}