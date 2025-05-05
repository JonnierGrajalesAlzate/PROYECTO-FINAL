using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class CheckInController : Controller
    {
        // Acción para registrar el ingreso de un huésped
        public ActionResult Index()
        {
            return View(); // Vista para realizar el check-in
        }
    }
}
