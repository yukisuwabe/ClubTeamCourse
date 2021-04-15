using System.Collections.Generic;
using ClubTeamCourse;

namespace CTCMvc.Models {
    public class TeamViewModel {
        public IList<Team> Teams {get; set;}
        public IList<CurrentTeam> CurrentTeams {get; set;}
        public IList<TeamWishList> TeamWishLists {get; set;}
    }

}