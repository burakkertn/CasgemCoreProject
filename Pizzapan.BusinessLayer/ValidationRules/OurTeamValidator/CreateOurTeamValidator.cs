

using FluentValidation;
using PizzaPan.EntityLayer.Concrete;

namespace Pizzapan.BusinessLayer.ValidationRules.OurTeamValidator
{
    public class CreateOurTeamValidator : AbstractValidator<OurTeam>
    {
        public CreateOurTeamValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soy İsim  Boş Geçilemez");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");

        }
    }
}
