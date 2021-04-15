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
    public class TeamController : Controller {
        private ClubTeamManagement db; 

        public TeamController(ClubTeamManagement injectedContext){
            db = injectedContext;
        }
        public async Task<IActionResult> Index() {
            var model = new TeamViewModel {
                Teams = await db.Team.ToListAsync(),
                CurrentTeams = await db.CurrentTeam.ToListAsync(),
                TeamWishLists = await db.TeamWishList.ToListAsync()
            };
            return View(model);
        }
        public async Task<IActionResult> TeamDetail(int? id){
            if (!id.HasValue){
                return NotFound("You must pass a team ID in the route, for example, /Team/TeamDetail/21");
            }
            var model = await db.Team.SingleOrDefaultAsync(p => p.TeamID ==id);
            if(model == null){
                return NotFound($"Team with ID of {id} not found.");
            }
            return View(model);
        }
    }
}