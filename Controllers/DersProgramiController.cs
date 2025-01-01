using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class DersProgramiController : Controller
    {
        public IActionResult Dersler()
        {
            // Ders programı görüntüleme sayfasını döndür
            return View();
        }
    }
}
