using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using VideoOnDemand.Models;
using AutoMapper;
using VideoOnDemand.Repositories;
using VideoOnDemand.Models.DTOModels;
using VideoOnDemand.Models.MembershipViewModels;

namespace VideoOnDemand.Controllers
{
    public class MembershipController : Controller
    {
        private string _userId;
        private readonly IMapper _mapper;
        private IReadRepository _db;

        public MembershipController(IHttpContextAccessor httpContextAccessor,
            UserManager<ApplicationUser> userManager, IMapper mapper, IReadRepository db)
        {
            // Get logged in user's UserId
            var user = httpContextAccessor.HttpContext.User;
            _userId = userManager.GetUserId(user);
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            var courseDtoObjects = _mapper.Map<List<CourseDTO>>(_db.GetCourses(_userId));  //In book, type is "CourseDto"? book's screenshot shows it should be DTO!

            var dashboardModel = new DashboardViewModel();
            dashboardModel.Courses = new List<List<CourseDTO>>();

            var noOfRows = courseDtoObjects.Count <= 3 ? 1 : courseDtoObjects.Count / 3;

            for (var i =0; i < noOfRows; i++)
            {
                dashboardModel.Courses.Add(courseDtoObjects.Take(3).ToList());
            }

            return View(dashboardModel);
        }

        [HttpGet]
        public IActionResult Course(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Video(int id)
        {
            return View();
        }
    }
}