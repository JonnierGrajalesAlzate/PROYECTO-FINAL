using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class HabitacionesController : Controller
    {
        // Acción para ver la lista de habitaciones
        public ActionResult Index()
        {
            return View(); // Devuelve la vista Index para gestionar las habitaciones
        }

        // Acción para crear una nueva habitación
        public ActionResult Create()
        {
            return View(); // Devuelve la vista Create para agregar una nueva habitación
        }

        // Acción para editar una habitación
        public ActionResult Edit(int id)
        {
            // Lógica para editar una habitación específica
            return View();
        }

        // Acción para eliminar una habitación
        public ActionResult Delete(int id)
        {
            // Lógica para eliminar una habitación
            return RedirectToAction("Index");
        }
    }
}
