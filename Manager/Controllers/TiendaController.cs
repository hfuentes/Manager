using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Manager.Models;

namespace Manager.Controllers
{
    public class TiendaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Tienda/
        public ActionResult Index()
        {
            var tiendas = db.Tiendas.Include(t => t.Administrador);
            return View(tiendas.ToList());
        }

        // GET: /Tienda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tiendas.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            return View(tienda);
        }

        // GET: /Tienda/Create
        public ActionResult Create()
        {
            ViewBag.AdministradorId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: /Tienda/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Referencia,AdministradorId")] Tienda tienda)
        {
            if (ModelState.IsValid)
            {
                db.Tiendas.Add(tienda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdministradorId = new SelectList(db.Users, "Id", "UserName", tienda.AdministradorId);
            return View(tienda);
        }

        // GET: /Tienda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tiendas.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdministradorId = new SelectList(db.Users, "Id", "UserName", tienda.AdministradorId);
            return View(tienda);
        }

        // POST: /Tienda/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Referencia,AdministradorId")] Tienda tienda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tienda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdministradorId = new SelectList(db.Users, "Id", "UserName", tienda.AdministradorId);
            return View(tienda);
        }

        // GET: /Tienda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tienda tienda = db.Tiendas.Find(id);
            if (tienda == null)
            {
                return HttpNotFound();
            }
            return View(tienda);
        }

        // POST: /Tienda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tienda tienda = db.Tiendas.Find(id);
            db.Tiendas.Remove(tienda);
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
