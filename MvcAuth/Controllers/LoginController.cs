using MvcAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAuth.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            UserManager manager = new UserManager();
            var loggedInUser = manager.Login(user.Username, user.Password);

            if (loggedInUser != null)
            {
                Session["user"] = loggedInUser;
                return View("Success", loggedInUser);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }


    }
}