using System.Web.Mvc;

namespace GestionHotelera.Controllers
{
    public class ReportesController : Controller
    {
        // Acción para ver los reportes generados
        public ActionResult Index()
        {
            return View(); // Vista para generar reportes
        }
    }
}
