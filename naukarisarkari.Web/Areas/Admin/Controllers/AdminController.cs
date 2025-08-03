using Microsoft.AspNetCore.Mvc;
namespace naukarisarkari.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IAdminRepo _adminRepo;

        public AdminController(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var admin = await _adminRepo.ValidateAdminAsync(username, password);
            if (admin != null)
            {
                // You can set session or cookie here
                return Redirect("/Admin/Admin/Dashboard");
            }

            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }



    }
}
