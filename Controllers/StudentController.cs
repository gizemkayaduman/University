using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class StudentController : Controller
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
                return RedirectToAction("Login", "Account");
            }

            // Hatalı giriş
            ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }
    
        public IActionResult OgrenciProgram()
        {
            // Öğrencinin kendi programını görüntüleme sayfasını döndür
            return View();
        }

        public IActionResult DersEkleCikar()
        {
            // Öğrenci ders ekleme/çıkarma sayfasını döndür
            return View();
        }
    }
}
