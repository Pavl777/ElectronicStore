using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ElectronicStore.Models.Catalog;


namespace ElectronicStore.Controllers
{
    public class CatalogController : Controller
    {
        private ProductDBContext db = new ProductDBContext();


        // GET: Products
        public ActionResult Index(int? orderId,string searchString)
        {
            var product = from m in db.Products
                         select m;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                product = product.Where(s => s.Name.Contains(searchString));
            }
            ViewBag.orderId = orderId;
            return View(product);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id,int? orderId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.orderId = orderId ?? 0;
            return View(product);
        }


        // GET: Products/Create
       

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            else
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
   }
    
}
