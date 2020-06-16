using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranQuangDuy_lap456.Models;
using TranQuangDuy_lap456.ViewModel;

namespace TranQuangDuy_lap456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);     
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
      
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DataTime = viewModel.GetDateTime(),
               
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}