using Microsoft.AspNetCore.Mvc;
using ThirdMVCAppDemo.DAL;

namespace ThirdMVCAppDemo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            SecondMvcappDemoContext db = new SecondMvcappDemoContext();
            var genders = db.Genders.ToList();

            ViewBag.GenderList = genders;
            UserRegistrationViewModel userVM = new UserRegistrationViewModel();
            return View(userVM);
        }

        [HttpPost]
        public IActionResult Registration(UserRegistrationViewModel userVM)
        {
           
            SecondMvcappDemoContext db = new SecondMvcappDemoContext();
            if (ModelState.IsValid == true)
            {
                //Convert From UserViewModel to UserDTO MOdel
                User user = new User();     //DTO
                user.Email = userVM.Email;
                user.FirstName = userVM.FirstName;
                user.LastName = userVM.LastName;
                user.GenderId = userVM.GenderId;
                user.Password = userVM.Password;
                user.MobileNumber = userVM.MobileNumber;


                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index","User");
            }

            var genders = db.Genders.ToList();
            ViewBag.GenderList = genders;
            return View(userVM);
        } 

        public IActionResult IsEmailIdValid(string emailId)
        {
            SecondMvcappDemoContext db = new SecondMvcappDemoContext();
            var isEmailIdPresentInDB = db.Users.Any(u => u.Email == emailId);
           
            if(isEmailIdPresentInDB == true)
            {
                return Json("The Email Id is Present in the DataBase Plase Choose Another Email Id");
            }
            else
            {
                return Json(true);
            }

            
        }
    }
}
