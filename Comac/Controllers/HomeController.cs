using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comac.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                RedirectToAction("Login", "Login");
                RedirectToAction("DenemeLog", "DenemeLog");
            }
            
            return View();
        }
    }
}