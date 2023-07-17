using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.PresentationLayer.Models;
using PizzaPan.EntityLayer.Concrete;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.name = values.Name;
            model.email = values.Email;
            model.surname = values.SurName;
            model.city = values.City;
            model.username = values.UserName;

           
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = model.name;
            user.SurName = model.surname;
            user.City = model.city;
            user.Email = model.email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.password);
            var result = await _userManager.UpdateAsync(user);

            

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                               return View();
                }
         


        }
}
}
