using System.Linq;
using System.Web.Mvc;
using TienditaMVC.Models;

namespace TienditaMVC.Controllers
{
    public class ArticuloController : Controller
    {
        private HotelDBContext db = new HotelDBContext();

        // GET: Articulo
        public ActionResult Index()
        {
            return View(db.Articulos.ToList());
        }

        // GET: Articulo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articulo/Create
        [HttpPost]
        public ActionResult Create(Articulo articulo)
        {
            db.Articulos.Add(articulo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Articulo/Edit/5
        public ActionResult Edit(int id)
        {
            var articulo = db.Articulos.Find(id);
            if (articulo == null) return HttpNotFound();
            return View(articulo);
        }

        // POST: Articulo/Edit/5
        [HttpPost]
        public ActionResult Edit(Articulo articulo)
        {
            db.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Articulo/Delete/5
        public ActionResult Delete(int id)
        {
            var articulo = db.Articulos.Find(id);
            if (articulo == null) return HttpNotFound();
            return View(articulo);
        }

        // POST: Articulo/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var articulo = db.Articulos.Find(id);
            db.Articulos.Remove(articulo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Articulo/Details/5
        public ActionResult Details(int id)
        {
            var articulo = db.Articulos.Find(id);
            if (articulo == null) return HttpNotFound();
            return View(articulo);
        }
    }
}