using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FridayLunch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            ViewBag.Message = "Change Your password.";

            return View();
        }

        public ActionResult MainWindow()
        {
            ViewBag.Message = "Main window here.";

            return View();
        }
    }
}