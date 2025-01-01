using Microsoft.AspNetCore.Mvc;
namespace University.Controllers
{
    public class BolumSekreteriController : Controller
    {
        // Öğrenci login sayfası
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Öğrenci login doğrulaması
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "student" && password == "12345")
            {
                TempData["Message"] = "Öğrenci girişi başarılı!";
                return RedirectToAction("Index", "Student");
            }

            // Hatalı giriş
            ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }
        
        public IActionResult OgrenciEkleCikar()
        {
            // Bölüm sekreterinin öğrenci ekleme/çıkarma sayfasını döndür
            return View();
        }

        public IActionResult DersProgramiEkleCikar()
        {
            // Ders programına ders ekleme/çıkarma sayfasını döndür
            return View();
        }
    }
}
