using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    [Authorize(Roles ="admin")]
    public class OrderController : Controller
    {
        DataContext db = new DataContext();
        // GET: Order
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AdminOrderModel()
            {
                ID=i.ID,
                OrderNumber=i.OrderNumber,
                OrderDate=i.OrderDate,
                OrderState=i.OrderState,
                Total=i.Total,
                Count=i.Orderlines.Count
            }).OrderByDescending(i=>i.OrderDate).ToList();
            return View(orders);
        }
        public ActionResult Details(int id)
        {
            var entity = db.Orders
                .Where(i => i.ID == id)
                .Select(i => new OrderDetailsModel()
                {
                    OrderID = i.ID,
                    UserName=i.Username,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    AdresBasligi = i.AdresBasligi,
                    Adres = i.Adres,
                    Sehir = i.Sehir,
                    Semt = i.Semt,
                    Mahalle = i.Mahalle,
                    PostaKodu = i.PostaKodu,
                    Orderlines = i.Orderlines.Select(a => new OrderLineModel()
                    {
                        ProductID = a.ProductID,
                        ProductName = a.Product.Name.Length > 50 ? a.Product.Name.Substring(0, 47) + "..." : a.Product.Name,
                        Image = a.Product.Image,
                        Quantity = a.Quantity,
                        Price = a.Price

                    }).ToList()

                }).FirstOrDefault();
            return View(entity);
        }
        public ActionResult UpdateOrderState(int OrderID, EnumOrderState OrderState)
        {
            var order = db.Orders.FirstOrDefault(i => i.ID == OrderID);
            if (order!=null)
            {
                order.OrderState = OrderState;
                db.SaveChanges();
                TempData["message"] = "Bilgiler Kayıt Edildi!";

                return RedirectToAction("Details", new { id = OrderID });

            }
            return RedirectToAction("Index");
        }
    }
}