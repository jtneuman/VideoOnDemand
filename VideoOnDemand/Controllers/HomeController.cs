using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using VideoOnDemand.Models;
using VideoOnDemand.Repositories;

namespace VideoOnDemand.Controllers
{
    public class HomeController : Controller
    {
        private SignInManager<ApplicationUser> _signInManager;

        public HomeController(SignInManager<ApplicationUser> signInMgr)
        {
            _signInManager = signInMgr;
        }
        public IActionResult Index()
        {
            //var rep = new MockReadRepository();
            //// Get all courses for user
            //var courses = rep.GetCourses("e28bcfc0-fe61-4c69-867e-3532527dbb64");
            //// Get single course
            //var course = rep.GetCourse("e28bcfc0-fe61-4c69-867e-3532527dbb64", 1);

            //var video = rep.GetVideo("e28bcfc0-fe61-4c69-867e-3532527dbb64", 1);

            //var videos = rep.GetVideos("e28bcfc0-fe61-4c69-867e-3532527dbb64");

            //var videosForModule = rep.GetVideos("e28bcfc0-fe61-4c69-867e-3532527dbb64", 1);

            //check if user is signed in and redirect to login in AcctContr if anonymous; otherwise open default view
            if (!_signInManager.IsSignedIn(User))
                return RedirectToAction("Login", "Account");

            return RedirectToAction("Dashboard", "Membership");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
