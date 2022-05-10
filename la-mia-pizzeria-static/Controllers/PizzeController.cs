using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Utils;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizze = PizzaData.GetPizze();
            return View("HomePage", pizze);
        }

        




    }
}
