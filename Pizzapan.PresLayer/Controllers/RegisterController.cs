using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.PresentationLayer.Models;
using PizzaPan.EntityLayer.Concrete;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(RegisterViewModel model)
        {


            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = model.Name,
                    SurName = model.Surname,
                    Email = model.email,
                    UserName = model.Username,
                };

                await _userManager.CreateAsync(appUser, model.Password);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }

        }
    }
}
