using System.Linq;
using System.Net;
using System.Web.Mvc;
using TienditaMVC.Models;

namespace TienditaMVC.Controllers
{
    public class HuespedController : Controller
    {
        private HotelDBContext db = new HotelDBContext();

        // GET: Huespedes
        public ActionResult Index()
        {
            return View(db.Huespedes.ToList());
        }

        // GET: Huespedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Huesped huesped = db.Huespedes.Find(id);
            if (huesped == null)
                return HttpNotFound();

            return View(huesped);
        }

        // GET: Huespedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Huespedes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Huesped huesped)
        {
            if (ModelState.IsValid)
            {
                db.Huespedes.Add(huesped);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(huesped);
        }

        // GET: Huespedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Huesped huesped = db.Huespedes.Find(id);
            if (huesped == null)
                return HttpNotFound();

            return View(huesped);
        }

        // POST: Huespedes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Huesped huesped)
        {
            if (ModelState.IsValid)
            {
                db.Entry(huesped).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(huesped);
        }

        // GET: Huespedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Huesped huesped = db.Huespedes.Find(id);
            if (huesped == null)
                return HttpNotFound();

            return View(huesped);
        }

        // POST: Huespedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Huesped huesped = db.Huespedes.Find(id);
            db.Huespedes.Remove(huesped);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}
