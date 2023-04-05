using Microsoft.AspNetCore.Mvc;

namespace ThirdMVCAppDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
