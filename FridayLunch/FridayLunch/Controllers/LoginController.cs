using FridayLunch.Models;
using System.Web.Mvc;
using MongoDB.Driver;

namespace FridayLunch.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            //var connectionString = "mongodb://localhost:27017";
            //var client = new MongoClient(connectionString);
            //var database = client.GetDatabase("FridayLunch");
            //var collection = database.GetCollection<UserModel>("Users");
            //var userM = new UserModel
            //{
            //    Username = "Admin",
            //    Password = "Lietuva",
            //    FirstName = "Test1",
            //    LastName = "Tes2",
            //    Floor = 3,
            //    IsAdmin = true
            //};
            //collection.InsertOne(userM);
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var connectionString = "mongodb://localhost:27017";
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("FridayLunch");
                var collection = database.GetCollection<UserModel>("Users");


                var user = new UserModel
                {
                    Username = model.Username,
                    Password = model.Password
                };

                var result = collection.Find<UserModel>(x => x.Username == user.Username).FirstOrDefault();
                if (result != null)
                {
                    if (result.Password == user.Password)
                    {
                        if (result.IsAdmin)
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                            return RedirectToAction("MainWindow", "Home");
                        }

                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", model);
                }

                // collection.insertOne(user)
                // Call to database MONGO
                // Check if exist
                // if yes redirect to home screen (if user) or to admin screen (if admin)
                // else back to login with prefiled values


            }
            return RedirectToAction("Index", "Home", model);
        }

        public ActionResult EditUsers()
        {

            return RedirectToAction("Users", "Admin");
        }
    }
}