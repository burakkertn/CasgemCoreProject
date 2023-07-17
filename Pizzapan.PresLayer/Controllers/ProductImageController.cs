using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Security;
using Pizzapan.BusinessLayer.Abstact;
using Pizzapan.PresentationLayer.Models;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.IO;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(ImageFieldViewModel p)
        {
            var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/images/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);


                 p.Image.CopyTo(stream);

            ProductImage productImage = new ProductImage();

            productImage.ImageUrl = imagename;
            _productImageService.TInsert(productImage);

            return RedirectToAction("ImageList");
        }
    }
}
