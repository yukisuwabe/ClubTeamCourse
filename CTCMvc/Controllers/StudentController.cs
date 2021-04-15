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
using System.Web;
using Microsoft.AspNetCore.Http;

namespace CTCMvc.Controllers
{
    public class StudentController : Controller
    {
        private ClubTeamManagement db;
        public StudentController(ClubTeamManagement injectedContext)
        {
            db = injectedContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student objStudent)
        {
            if (ModelState.IsValid)
            {
                var check = db.Student.FirstOrDefault(s => s.Email == objStudent.Email);
                if (check == null)
                {
                    db.Student.Add(objStudent);
                    db.SaveChanges();
                    return RedirectToAction("StudentInfo");
                }
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var data = db.Student.Where(s => s.Email.Equals(email) && s.Password.Equals(password));
                if (data != null){
                    return RedirectToAction("StudentInfo");
                }
                
            }
            return RedirectToAction("Login");
        }
        public IActionResult StudentInfo(Student student)
        {
            return View(student);
        }
    }
}