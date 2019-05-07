using RecycleApp.DAL;
using RecycleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecycleApp.Controllers
{
    public class UserController : Controller
    {
        private DataContex db = new DataContex();
        // GET: User
        public ViewResult Index()
        {
            return View(db.Users.ToList());
        }
        
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }
    }
}