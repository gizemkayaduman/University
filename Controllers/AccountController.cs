using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class AccountController : Controller
    {
        // Kullanıcıdan giriş tipini seçmesini ister
        [HttpGet]
        public ActionResult SelectRole()
        {
            return View();
        }

        // Login işlemi için genel giriş ekranı
        [HttpGet]
        public IActionResult Login(string role)
        {
            // Rol parametresi ile giriş yapacak kişiyi belirler
            ViewBag.Role = role;  // Rolü View'e gönderir
            return View();
        }

        // Login işlemi için form post'uyla gelen veriyi kontrol eder
        [HttpPost]
        public IActionResult Login(string username, string password, string role)
        {
            // Rol ve giriş bilgilerine göre doğrulama yapılır
            if (role == "Ogrenci" && username == "student" && password == "12345")
            {
                TempData["Message"] = "Öğrenci girişi başarılı!";
                return RedirectToAction("Index", "Home");
            }
            else if (role == "BolumSekreteri" && username == "admin" && password == "12345")
            {
                TempData["Message"] = "Bölüm Sekreteri girişi başarılı!";
                return RedirectToAction("Index", "Home");
            }

            // Hatalı giriş durumu
            ViewBag.Error = "Kullanıcı adı, şifre veya rol hatalı.";
            ViewBag.Role = role; // Rolü geri View'e gönder
            return View();
        }
    }
}
