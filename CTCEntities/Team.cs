using System;
using System.Collections.Generic;

namespace ClubTeamCourse {
    public class Team {
        public int TeamID {get; set;}
        public string TeamName {get; set;}
        public string Season {get; set;}
        public string Gender {get; set;}
        public string Coach {get; set;}
        public string CoachEmail {get;set;}
        public DateTime? TryoutDate {get; set;}
        public string ScheduleLink {get;set;}
        public ICollection<CurrentTeam> CurrentTeams {get; set;}
        public ICollection<TeamWishList> TeamWishLists {get; set;}
    }
}