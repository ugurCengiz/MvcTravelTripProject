using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class LoginController : Controller
    {
        private Context c = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.User == ad.User && x.Password == ad.Password);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.User,false);
                Session["User"] = bilgiler.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }

    }
}