using LapBigSchool_ThaiAnhTu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace LapBigSchool_ThaiAnhTu.Controllers
{
    public class Homecontroller : Controller
    {
        private ApplicationDbContext _dbContext;

        public Homecontroller()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);

            return View(upcommingCourses);
        }
    }
}

