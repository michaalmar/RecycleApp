﻿using RecycleApp.DAL;
using RecycleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RecycleApp.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private DataContex db = new DataContex();

        // GET: Category
        public ViewResult Index()
        {
            return View(db.Categories.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
         
                if(ModelState.IsValid)
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                    return RedirectToAction("Index");    
                }
            
        return View(category);
        }
       
      
        public ActionResult Delete(int? id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();

            return RedirectToAction("Index");

        }


    }



}