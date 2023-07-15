using System.ComponentModel.DataAnnotations;

namespace Pizzapan.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Ad Boş Geçilemez.")]
        public string Name { get; set; }

        public string Surname { get; set; }
        [Required(ErrorMessage = "Mail Boş Geçilemez.")]
        public string email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfrimPassword { get; set; }


    }
}
