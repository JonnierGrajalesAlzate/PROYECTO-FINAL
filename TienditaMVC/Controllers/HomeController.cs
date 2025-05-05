using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class HomeController : Controller
    {
        // Acción para la página principal
        public ActionResult Index()
        {
            return View();
        }
    }
}
