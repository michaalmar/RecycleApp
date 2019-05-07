using RecycleApp.DAL;
using RecycleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RecycleApp.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User model, string returnUrl)
        {

            if (ModelState.IsValid)
            {
                using (DataContex db = new DataContex())
                {
                    string username = model.userName;
                    string password = model.password;

                    bool userValid = db.Users.Any(user => user.userName == username && user.password == password);

                    if (userValid)
                    {
                        FormsAuthentication.SetAuthCookie(username, false);

                        return Redirect(returnUrl);

                    }

                    ModelState.AddModelError("CredentialError", "Nieprawidłowe hasło lub nazwa użytkownika");


                }
            }

            return View(model);


        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Category");
        }
    }
}