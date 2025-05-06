using TienditaMVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace TienditaMVC.Controllers
{
    public class HabitacionController : Controller
    {
        private HotelDBContext db = new HotelDBContext();

        // GET: Habitacion
        public ActionResult Index()
        {
            return View(db.Habitaciones.ToList());
        }

        // GET: Habitacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Habitacion/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Habitacion habitacion)
        {
            if (ModelState.IsValid)
            {
                db.Habitaciones.Add(habitacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(habitacion);
        }

        // GET: Habitacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Habitacion habitacion = db.Habitaciones.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        // POST: Habitacion/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Habitacion habitacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(habitacion).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitacion);
        }

        // GET: Habitacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Habitacion habitacion = db.Habitaciones.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        // POST: Habitacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Habitacion habitacion = db.Habitaciones.Find(id);
            db.Habitaciones.Remove(habitacion);
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
