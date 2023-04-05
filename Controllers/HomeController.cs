using Microsoft.AspNetCore.Mvc;
using ThirdMVCAppDemo.Models;

namespace ThirdMVCAppDemo.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            SecondMvcappDemoContext db = new SecondMvcappDemoContext();
            var users = db.Users.ToList();

            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            SecondMvcappDemoContext db = new SecondMvcappDemoContext();
            db.Users.Add(user);
            db.SaveChanges();



            return RedirectToAction("Index");
        }
        public IActionResult Edit()
        {
            return View();
        }

    }
}
