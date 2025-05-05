using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class HuespedesController : Controller
    {
        // Acción para ver la lista de huéspedes
        public ActionResult Index()
        {
            return View(); // Devuelve la vista Index para gestionar los huéspedes
        }

        // Acción para crear un nuevo huésped
        public ActionResult Create()
        {
            return View(); // Devuelve la vista Create para agregar un nuevo huésped
        }

        // Acción para editar un huésped
        public ActionResult Edit(int id)
        {
            // Aquí iría la lógica para cargar los datos de un huésped específico por ID
            return View();
        }

        // Acción para eliminar un huésped
        public ActionResult Delete(int id)
        {
            // Aquí iría la lógica para eliminar un huésped por ID
            return RedirectToAction("Index"); // Redirige a la lista de huéspedes
        }
    }
}
