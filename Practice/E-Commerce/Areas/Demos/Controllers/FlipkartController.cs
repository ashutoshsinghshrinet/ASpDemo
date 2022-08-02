using Microsoft.AspNetCore.Mvc;


namespace E_Commerce.Areas.Demos.Controllers
{
    public class FlipkartController : Controller
    {
        public IActionResult Index()
        {
            return View("Sample");
        }
    }
}
