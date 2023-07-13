using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstact;
using Pizzapan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetList();
            return View(values);
        
        }
        [HttpGet]
        public IActionResult AddProduct()

        {

            return View();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            return RedirectToAction("Index");

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _productService.TGetById(id);
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]

        public IActionResult UpdateProduct(Product product)
        {


            _productService.TUpdate(product);

            return RedirectToAction("Index");



        }
    }
}
