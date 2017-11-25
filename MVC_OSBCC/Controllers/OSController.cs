using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5.Models;
using MVC_OSBCC.Models;

namespace MVC_OSBCC.Controllers
{
    [Authorize(Roles="Admin")]
    public class OSController : Controller
    {
        private Contexto db = new Contexto();

        // GET: OS
        public ActionResult Index()
        {
            return View(db.OrdemServico.ToList());
        }

        // GET: OS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS oS = db.OrdemServico.Find(id);
            if (oS == null)
            {
                return HttpNotFound();
            }
            return View(oS);
        }

        // GET: OS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,aparelho,descricao,valor")] OS oS)
        {
            if (ModelState.IsValid)
            {
                db.OrdemServico.Add(oS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oS);
        }

        // GET: OS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS oS = db.OrdemServico.Find(id);
            if (oS == null)
            {
                return HttpNotFound();
            }
            return View(oS);
        }

        // POST: OS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,aparelho,peca,descricao,valor")] OS oS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oS);
        }

        // GET: OS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS oS = db.OrdemServico.Find(id);
            if (oS == null)
            {
                return HttpNotFound();
            }
            return View(oS);
        }

        // POST: OS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS oS = db.OrdemServico.Find(id);
            db.OrdemServico.Remove(oS);
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
