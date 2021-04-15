using System.Collections.Generic;

namespace ClubTeamCourse
{
    public class ClubCategory
    {
        public int ClubCategoryID {get; set;}
        public string CategoryName {get; set;}
        public ICollection<ClubList> ClubList {get; set;}
    }
}
