using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {

     
        // GET: Product
        ACME_DBEntities db = new ACME_DBEntities();
        public ActionResult Index(string option, string search, string id)
        {
            
           

            if (option == "Category")
            {
               
                return View(db.PRODUCTS.Where(x => x.PRODUCT_CATEGORY.Contains(search) || search == null).ToList());
            }
            else if (option == "Code")
            {
                return View(db.PRODUCTS.Where(x => x.PRODUCT_CODE.Contains(search) || search == null).ToList());
            }
            else
            {
                return View(db.PRODUCTS.Where(x => x.PRODUCT_NAME.Contains(search) || search == null).ToList());
            }

           

            
            
        }

        

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
