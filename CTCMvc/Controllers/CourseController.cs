using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CTCMvc.Models;
using ClubTeamCourse;
using Microsoft.EntityFrameworkCore;


namespace CTCMvc.Controllers {
    public class CourseController : Controller {
        private ClubTeamManagement db; 

        public CourseController(ClubTeamManagement injectedContext){
            db = injectedContext;
        }
        public async Task<IActionResult> Index() {
            var model = new CourseViewModel {
                Courses = await db.Course.ToListAsync(),
                CurrentCourses = await db.CurrentCourse.ToListAsync(),
                CourseRecs = await db.CourseRec.ToListAsync(),
                CourseWishLists = await db.CourseWishList.ToListAsync()
            };
            return View(model);
        }
        public async Task<IActionResult> CourseDetail(int? id){
            if (!id.HasValue){
                return NotFound("You must pass a course ID in the route, for example, /Course/CourseDetail/21");
            }
            var model = await db.Course.SingleOrDefaultAsync(p => p.CourseID ==id);
            if(model == null){
                return NotFound($"Course with ID of {id} not found.");
            }
            return View(model);
        }
    }
}