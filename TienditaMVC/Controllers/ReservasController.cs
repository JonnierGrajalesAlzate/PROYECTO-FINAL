using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class ReservasController : Controller
    {
        // Acción para ver la lista de reservas
        public ActionResult Index()
        {
            return View(); // Devuelve la vista Index para gestionar las reservas
        }

        // Acción para hacer una nueva reserva
        public ActionResult Create()
        {
            return View(); // Devuelve la vista Create para realizar una nueva reserva
        }

        // Acción para editar una reserva
        public ActionResult Edit(int id)
        {
            // Lógica para editar una reserva
            return View();
        }

        // Acción para cancelar una reserva
        public ActionResult Delete(int id)
        {
            // Lógica para cancelar una reserva
            return RedirectToAction("Index");
        }
    }
}
