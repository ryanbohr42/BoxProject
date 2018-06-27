using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoxProblem.Data;
using BoxProblem.Services;
using Microsoft.AspNetCore.Mvc;

namespace BoxProblem.Controllers
{
    public class BoxController : Controller
    {
        private BoxService service;

        public BoxController(ApplicationDbContext context)
        {
            service = new BoxService(context);
        }

        // GET: Box
        public IActionResult Index()
        {
            return View(service.GetAllBoxes());
        }

        // GET: Box/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Box/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BoxInventory box)
        {
            if (ModelState.IsValid)
            {
                service.AddBox(box);
                return RedirectToAction("Index");
            }
            return View(box);
        }

        // GET: Box/Edit
        public ActionResult Edit(int id)
        {
            BoxInventory box = service.GetBoxById(id);
            return View(box);
        }

        // POST: Box/Edit
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BoxInventory box)
        {
            if (ModelState.IsValid)
            {
                service.EditBox(box);
                return RedirectToAction("Index");
            }
            return View(box);
        }

        // GET: Box/Delete
        public ActionResult Delete(int id)
        {
            BoxInventory box = service.GetBoxById(id);
            return View(box);
        }

        // POST: Box/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BoxInventory box = service.GetBoxById(id);
            service.DeleteBox(box);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Search(int? weight, int? volume, bool? canHoldLiquid)
        {
            return View("Index", service.Search(weight, volume, canHoldLiquid, cost));
        }

    }
}