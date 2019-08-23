using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WelcareForYou_Iteration_1.Models;

namespace WelcareForYou_Iteration_1.Controllers
{
    public class HousingsController : Controller
    {
        private Iteration1ModelContainer db = new Iteration1ModelContainer();

        // GET: Housings
        public ActionResult Index()
        {
            return View(db.Housings.ToList());
        }

        // GET: Housings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Housing housing = db.Housings.Find(id);
            if (housing == null)
            {
                return HttpNotFound();
            }
            return View(housing);
        }

        // GET: Housings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Housings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Suburb,NumOfRoom,MediumPrice,HouseType")] Housing housing)
        {
            if (ModelState.IsValid)
            {
                db.Housings.Add(housing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(housing);
        }

        // GET: Housings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Housing housing = db.Housings.Find(id);
            if (housing == null)
            {
                return HttpNotFound();
            }
            return View(housing);
        }

        // POST: Housings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Suburb,NumOfRoom,MediumPrice,HouseType")] Housing housing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(housing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(housing);
        }

        // GET: Housings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Housing housing = db.Housings.Find(id);
            if (housing == null)
            {
                return HttpNotFound();
            }
            return View(housing);
        }

        // POST: Housings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Housing housing = db.Housings.Find(id);
            db.Housings.Remove(housing);
            db.SaveChanges();
            return RedirectToAction("Index");
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
