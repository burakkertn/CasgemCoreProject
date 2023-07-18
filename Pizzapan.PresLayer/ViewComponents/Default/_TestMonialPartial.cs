using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstact;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
  
    public class _TestMonialPartial : ViewComponent
    {  
        private readonly ITestimonialService _testimonialService;

        public _TestMonialPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _testimonialService.TGetList();
            return View(values); 
        } 
    }
}
