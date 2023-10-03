using Microsoft.AspNetCore.Mvc;

namespace ClubCar.Controllers
{
    public class Tools : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
