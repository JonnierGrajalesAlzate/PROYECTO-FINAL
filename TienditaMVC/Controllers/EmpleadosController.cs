using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class EmpleadosController : Controller
    {
        // Acción para ver la lista de empleados
        public ActionResult Index()
        {
            return View(); // Devuelve la vista Index para gestionar los empleados
        }

        // Acción para crear un nuevo empleado
        public ActionResult Create()
        {
            return View(); // Devuelve la vista Create para agregar un nuevo empleado
        }

        // Acción para editar un empleado
        public ActionResult Edit(int id)
        {
            // Lógica para editar un empleado
            return View();
        }

        // Acción para eliminar un empleado
        public ActionResult Delete(int id)
        {
            // Lógica para eliminar un empleado
            return RedirectToAction("Index");
        }
    }
}
