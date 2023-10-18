using Microsoft.AspNetCore.Mvc;
using Lab2.Views.Birth;
using Lab2.Views.Calculator;

namespace Lab2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Birth model)
        {

            return View(model);
        }
    }
}
