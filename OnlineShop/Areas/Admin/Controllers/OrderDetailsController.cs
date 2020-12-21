using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class OrderDetailsController : Controller
    {
        private OnlineShopDbContext db = new OnlineShopDbContext();

        // GET: Admin/OrderDetails
        public ActionResult Index()
        {
            return View(db.OrderDetails.ToList());
        }

        // GET: Admin/OrderDetails/Details/5
        public ActionResult Details(long? id1, long? id2)
        {
            if (id1 == null || id1 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderDetail = db.OrderDetails.Find(id1, id2);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // GET: Admin/OrderDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/OrderDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,OrderID,Quantity,Price")] OrderDetail orderDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu! " + ex.Message;
                return View(orderDetail);
            }
        }

        // GET: Admin/OrderDetails/Edit/5
        public ActionResult Edit(long? id1, long? id2)
        {
            if (id1 == null || id1 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderDetail = db.OrderDetails.Find(id1, id2);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // POST: Admin/OrderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,OrderID,Quantity,Price")] OrderDetail orderDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu! " + ex.Message;
                return View(orderDetail);
            }
        }

        // GET: Admin/OrderDetails/Delete/5
        public ActionResult Delete(long? id1, long? id2)
        {
            if (id1 == null || id1 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderDetail = db.OrderDetails.Find(id1, id2);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // POST: Admin/OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id1, long id2)
        {
            OrderDetail orderDetail = db.OrderDetails.Find(id1, id2);
            try
            {
                db.OrderDetails.Remove(orderDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = "Không xóa được đơn hàng này! " + ex.Message;
                return View("Delete", orderDetail);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
