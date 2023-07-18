using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Cryptography;
using Pizzapan.BusinessLayer.Abstact;
using Pizzapan.BusinessLayer.ValidationRules.OurTeamValidator;
using PizzaPan.EntityLayer.Concrete;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class OurTeamsController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public OurTeamsController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOurTeam(OurTeam ourTeam)
        {
            CreateOurTeamValidator createOurTeamValidator = new CreateOurTeamValidator();
            ValidationResult result = createOurTeamValidator.Validate(ourTeam);

            if (ModelState.IsValid)
            {
                _ourTeamService.TInsert(ourTeam);
                return RedirectToAction("Index");


            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();
        }
    }
}