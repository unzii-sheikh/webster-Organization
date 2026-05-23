using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class manager : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
        public IActionResult managerdash()
        {
            return View();
        }

    }
}
