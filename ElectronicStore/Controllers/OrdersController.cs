using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ElectronicStore.Models;
using ElectronicStore.Models.Catalog;

namespace ElectronicStore.Controllers
{
    public class OrdersController : Controller
    {
       
        private ProductDBContext db = new ProductDBContext();
      [HttpPost]
        public ActionResult AddItem(OrderDetails od)
        {
            if(od.OrderId == 0)
            {  
               
                Order order = new Order();
                db.Orders.Add(order);
                
                db.SaveChanges();
                od.OrderId = order.Id;
               
            }
            
            OrderDetails orderDetails = new OrderDetails() { OrderId = od.OrderId, ProductId = od.ProductId, Quantity = od.Quantity };
            db.OrderDetails.Add(orderDetails);
            db.SaveChanges();
            ViewBag.OrderId = od.OrderId;

            
            

            
            return View("Completed",model:"Product was added");
            
        }
      
        // GET: Orders
        public ActionResult Index()
        {
           
            return View(db.Orders.ToList());
        }
        
        public ActionResult CartAction(int? id)
        {
            Order order = new Order();
            if (id != null)
            {
                order = db.Orders.Find(id);
            }
            return View(order);
        }
        [HttpPost]
        public ActionResult CartAction(Order order)
        {
            Order dbOrder = db.Orders.Find(order.Id);
            dbOrder.Email = order.Email;
            dbOrder.Name = order.Name;
            dbOrder.SurName = order.SurName;
            dbOrder.Id = order.Id;
            dbOrder.IsCopleted = true;
            db.SaveChanges();

            return View("Completed",model:"Order was confirmed");
        }



        
    }
}
