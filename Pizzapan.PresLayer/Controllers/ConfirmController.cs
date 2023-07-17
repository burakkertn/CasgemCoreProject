using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.PresentationLayer.Models;
using PizzaPan.EntityLayer.Concrete;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ConfirmEmailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ConfirmEmailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.username = TempData["Username"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ConfrimViewModel vm)
        {
            var user = await _userManager.FindByNameAsync(vm.Username);
            if (user.ConfrimCode.ToString() == vm.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}