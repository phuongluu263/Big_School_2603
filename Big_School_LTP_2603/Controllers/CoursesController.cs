using Big_School_LTP_2603.Models;
using Big_School_LTP_2603.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Big_School_LTP_2603.Controllers
{
        // GET: Courses
        public class CoursesController : Controller
        {
            // GET: Course
            private readonly ApplicationDbContext _dbContext;
            public CoursesController()
            {
                _dbContext = new ApplicationDbContext();
            }
            [Authorize]
            public ActionResult Create()
            {
                var viewModel = new CourseViewModels
                {
                    Categories = _dbContext.Categories.ToList()
                };
                return View(viewModel);
            }
            [Authorize]
            [HttpPost]
            public ActionResult Create(CourseViewModels viewModel)
            {
                var course = new Course
                {
                    LecturerId = User.Identity.GetUserId(),
                    DateTime = viewModel.GetDateTime(),
                    CategoryId = viewModel.Category,
                    Place = viewModel.Place
                };
                _dbContext.Courses.Add(course);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
        }
}