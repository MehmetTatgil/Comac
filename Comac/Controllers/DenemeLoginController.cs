using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comac.Models;
namespace Comac.Controllers
{
    public class DenemeLoginController : Controller
    {
        // GET: DenemeLogin
        public ActionResult DenemeLog()
        {

            int i = 5;
            return View();
        }

        [HttpPost]
        public ActionResult DenemeLog(string name, string password)
        {
            if ("admin".Equals(name) && "123".Equals(password))
            {
                Session["user"] = new User() { Login = name, Name = "Kullanıcı" };

                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}