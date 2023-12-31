﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EquestrianProject.Models;

namespace EquestrianProject.Controllers
{
    public class ClientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clients
        public ActionResult Index()
        {
            var client = db.Client.Include(c => c.EquestrianType).Include(c => c.SubscriptionPlan);
            return View(client.ToList());
        }

        // GET: Clients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            ViewBag.EquestrianTypeID = new SelectList(db.EquestrianType, "EquestrianTypeID", "EquestrianTypeName");
            ViewBag.SubscriptionPlanID = new SelectList(db.SubscriptionPlan, "SubscriptionPlanID", "SubscriptionPlanName");
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientID,ClientName,Gender,DateOfParticipation,BirthDate,PhoneNumber,Email,ReferedBy,PriceCost,Discount,PaidCost,RemainingCost,Notes,SubscriptionPlanID,EquestrianTypeID")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Client.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EquestrianTypeID = new SelectList(db.EquestrianType, "EquestrianTypeID", "EquestrianTypeName", client.EquestrianTypeID);
            ViewBag.SubscriptionPlanID = new SelectList(db.SubscriptionPlan, "SubscriptionPlanID", "SubscriptionPlanName", client.SubscriptionPlanID);
            return View(client);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            ViewBag.EquestrianTypeID = new SelectList(db.EquestrianType, "EquestrianTypeID", "EquestrianTypeName", client.EquestrianTypeID);
            ViewBag.SubscriptionPlanID = new SelectList(db.SubscriptionPlan, "SubscriptionPlanID", "SubscriptionPlanName", client.SubscriptionPlanID);
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientID,ClientName,Gender,DateOfParticipation,BirthDate,PhoneNumber,Email,ReferedBy,PriceCost,Discount,PaidCost,RemainingCost,Notes,SubscriptionPlanID,EquestrianTypeID")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EquestrianTypeID = new SelectList(db.EquestrianType, "EquestrianTypeID", "EquestrianTypeName", client.EquestrianTypeID);
            ViewBag.SubscriptionPlanID = new SelectList(db.SubscriptionPlan, "SubscriptionPlanID", "SubscriptionPlanName", client.SubscriptionPlanID);
            return View(client);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Client.Find(id);
            db.Client.Remove(client);
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
