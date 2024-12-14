using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AddController1 : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult About()
        {
            return View(); 
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }

    }
}
