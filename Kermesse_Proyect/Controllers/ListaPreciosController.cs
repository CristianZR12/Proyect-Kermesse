using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kermesse_Proyect.Models;

namespace Kermesse_Proyect.Controllers
{
    public class ListaPreciosController : Controller
    {
        private BDKermesseEntities db = new BDKermesseEntities();

        // GET: ListaPrecios
        public ActionResult Index()
        {
            var listaPrecio = db.ListaPrecio.Include(l => l.Kermesse1);
            return View(listaPrecio.ToList());
        }

        // GET: ListaPrecios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaPrecio listaPrecio = db.ListaPrecio.Find(id);
            if (listaPrecio == null)
            {
                return HttpNotFound();
            }
            return View(listaPrecio);
        }

        // GET: ListaPrecios/Create
        public ActionResult Create()
        {
            ViewBag.kermesse = new SelectList(db.Kermesse, "idKermesse", "nombre");
            return View();
        }

        // POST: ListaPrecios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idListaPrecio,kermesse,nombre,descripcion,estado")] ListaPrecio listaPrecio)
        {
            if (ModelState.IsValid)
            {
                db.ListaPrecio.Add(listaPrecio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.kermesse = new SelectList(db.Kermesse, "idKermesse", "nombre", listaPrecio.kermesse);
            return View(listaPrecio);
        }

        // GET: ListaPrecios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaPrecio listaPrecio = db.ListaPrecio.Find(id);
            if (listaPrecio == null)
            {
                return HttpNotFound();
            }
            ViewBag.kermesse = new SelectList(db.Kermesse, "idKermesse", "nombre", listaPrecio.kermesse);
            return View(listaPrecio);
        }

        // POST: ListaPrecios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idListaPrecio,kermesse,nombre,descripcion,estado")] ListaPrecio listaPrecio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listaPrecio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.kermesse = new SelectList(db.Kermesse, "idKermesse", "nombre", listaPrecio.kermesse);
            return View(listaPrecio);
        }

        // GET: ListaPrecios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListaPrecio listaPrecio = db.ListaPrecio.Find(id);
            if (listaPrecio == null)
            {
                return HttpNotFound();
            }
            return View(listaPrecio);
        }

        // POST: ListaPrecios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListaPrecio listaPrecio = db.ListaPrecio.Find(id);
            db.ListaPrecio.Remove(listaPrecio);
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
