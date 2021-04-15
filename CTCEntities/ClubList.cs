using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubTeamCourse {
    public class ClubList {
        [Key]
        public int ClubID {get; set;}
        public string ClubName {get; set;}
        public string MeetingDay {get; set;}
        public string RemoteLink {get; set;}
        public string MeetingTime {get; set;}
        public string Advisor {get; set;}
        public string AdvisorEmail {get; set;}
        public string PresidentFirst {get; set;}
        public string PresidentLast {get; set;}
        public string PresidentEmail {get; set;}
        public string VPresFirst {get; set;}
        public string VPresLast {get; set;}
        public string VPEmail {get; set;}
        public string SecFirst {get; set;}
        public string SecLast {get; set;}
        public string SecEmail {get; set;}
        public int? CategoryID {get; set;}
        public ClubCategory Category {get; set;}
        public ICollection<ClubRec> ClubRec {get; set;}
        public ICollection<CurrentClubs> CurrentClubs {get; set;}
    }
}