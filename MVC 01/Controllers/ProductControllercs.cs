using Microsoft.AspNetCore.Mvc;
using MVC_01.Models;
using static MVC_01.Models.Product;

namespace MVC_01.Controllers
{
    [Route("Prod")]
    public class ProductControllercs : Controller
    {
        #region Action

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Products>()
            {
             new() { Id = 1, Name = "Laptop", Price = 25000 },
             new() { Id = 2, Name = "Phone",  Price = 12000 },
             new() { Id = 3, Name = "Mouse",  Price = 300 },

            };
            return Json(products);
        }
        public IActionResult GetProductById(int id)
        {
            if (id < 0)
                return BadRequest();

            else if (id > 50)
                return Redirect("https://www.google.com");

            else
                return Json(new Product() { Id = id });
        }
    
    #endregion
    #region Routing
    


        [HttpGet("json")]
        public IActionResult JsonAction()
        {
            return Json("Hello From Json Action");
        }


        #endregion
    } 
}
