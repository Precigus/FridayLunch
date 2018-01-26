using FridayLunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FridayLunch.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        var user = new UserModel
        //        {
        //            UserName = model.UserName,
        //            Password = model.Password
        //        };
        //        // collection.insertOne(user)
        //        // Call to database MONGO
        //        // Check if exist
        //        // if yes redirect to home screen
        //        // else back to login with prefiled values
        //        return RedirectToAction("MainWindow","Home");
        //    }
        //    return RedirectToAction("Index", "Home", model);
        //}

        //public ActionResult EditUsers()
        //{

        //    return RedirectToAction("Users", "Admin");
        //}
    }
}