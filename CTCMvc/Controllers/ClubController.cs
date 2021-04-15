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
    public class ClubController : Controller {
        private ClubTeamManagement db; 

        public ClubController(ClubTeamManagement injectedContext){
            db = injectedContext;
        }
        public async Task<IActionResult> Index() {
            var model = new ClubViewModel {
                ClubLists = await db.ClubList.ToListAsync(),
                CurrentClubs = await db.CurrentClubs.ToListAsync(),
                ClubRecs = await db.ClubRec.ToListAsync(),
            };
            return View(model);
        }
        public async Task<IActionResult> ClubDetail(int? id){
            if (!id.HasValue){
                return NotFound("You must pass a club ID in the route, for example, /Club/ClubDetail/21");
            }
            var model = await db.ClubList.SingleOrDefaultAsync(p => p.ClubID ==id);
            if(model == null){
                return NotFound($"Club with ID of {id} not found.");
            }
            return View(model);
        }
    }
}