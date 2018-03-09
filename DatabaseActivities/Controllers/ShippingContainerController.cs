using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;

namespace DatabaseActivities.Controllers
{
    public class ShippingContainerController: Controller
    {
        private ShippingContainerService service = new ShippingContainerService();

        // GET: Students
        public ActionResult Index()
        {
            return View(service.GetAllShippingContainers());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingContainer shippingContainer = service.GetShippingContainerByID((int)id);
            if (shippingContainer == null)
            {
                return HttpNotFound();
            }
            return View(shippingContainer);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,weight,destination,luckyNumber")] ShippingContainer shippingContainer)
        {
            if (ModelState.IsValid)
            {
                service.AddPackage(shippingContainer);
                return RedirectToAction("Index");
            }

            return View(shippingContainer);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingContainer shippingContainer = service.GetShippingContainerByID((int)id);
            if (shippingContainer == null)
            {
                return HttpNotFound();
            }
            return View(shippingContainer);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,weight,destination,luckyNumber")]ShippingContainer shippingContainer)
        {
            if (ModelState.IsValid)
            {
                service.EditPackage(shippingContainer);
                return RedirectToAction("Index");
            }
            return View(shippingContainer);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             ShippingContainer shippingContainer = service.GetShippingContainerByID((int)id);
            if (shippingContainer == null)
            {
                return HttpNotFound();
            }
            return View(shippingContainer);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShippingContainer shippingContainer = service.GetShippingContainerByID(id);
            service.DeleteShippingContainer(shippingContainer);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult WeightCompare(int userWeight)
        {
            return View("Index", service.WeightCompare(userWeight));
        }
    }
}
