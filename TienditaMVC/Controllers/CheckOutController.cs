using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class CheckOutController : Controller
    {
        // Acción para registrar la salida de un huésped
        public ActionResult Index()
        {
            return View(); // Vista para realizar el check-out
        }
    }
}
