using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HelloController1 : Controller
    {
        public IActionResult Happy()
        {
            ViewBag.Message = "Message From View Bag";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();
            string[] fruits = { "Apple", "Mango", "Banana", "Orange" };
            ViewBag.FruitsArray = fruits;
            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
            };
            return View();
        }
    }
}
