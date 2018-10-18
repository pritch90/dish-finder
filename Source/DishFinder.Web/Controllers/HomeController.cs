using Microsoft.AspNetCore.Mvc;

namespace DishFinder.Web.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}