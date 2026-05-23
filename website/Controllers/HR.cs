using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class HR : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "HR")]
        public IActionResult Hrdashboard()
        {
            return View();
        }

    }
}
