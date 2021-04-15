using System.Collections.Generic;
using ClubTeamCourse;

namespace CTCMvc.Models {
    public class ClubViewModel {
        public IList<ClubList> ClubLists {get; set;}
        public IList<ClubRec> ClubRecs {get; set;}
        public IList<CurrentClubs> CurrentClubs {get; set;}
    }

}