using RecycleApp.DAL;
using RecycleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecycleApp.Controllers
{
    public class TrashController : Controller
    {
        private DataContex db = new DataContex();
        // GET: Trash
        public ViewResult Index(string searchString)
        {
            var catrgory = from c in db.Categories
                        select c;

            var trash = from t in db.Trashes
                        select t;
            
            if(!String.IsNullOrEmpty(searchString))
            {
                trash = trash.Where(t => t.Category.Name.Contains(searchString));
            }

            return View(trash.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Trash trash)
        {

            if (ModelState.IsValid)
            {
                db.Trashes.Add(trash);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trash);
        }

        public ActionResult Delete(int? id)
        {
            Trash trash = db.Trashes.Find(id);
            db.Trashes.Remove(trash);
            db.SaveChanges();

            return RedirectToAction("Index");        }


    }
}