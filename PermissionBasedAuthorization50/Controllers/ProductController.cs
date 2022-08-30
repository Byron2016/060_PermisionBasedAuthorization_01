using Microsoft.AspNetCore.Mvc;

namespace PermissionBasedAuthorization50.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
