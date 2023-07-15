using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Pizzapan.BusinessLayer.Abstact;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using PizzaPan.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        
        }
        [HttpGet]
        
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return RedirectToAction("Index");

        }

        public IActionResult GetByMessage()
        {
            var values = _contactService.TGetConnactBySubject();
            return View(values);

        }
    }
}
