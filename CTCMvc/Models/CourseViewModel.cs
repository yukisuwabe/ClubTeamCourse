using System.Collections.Generic;
using ClubTeamCourse;

namespace CTCMvc.Models {
    public class CourseViewModel {
        public IList<Course> Courses {get; set;}
        public IList<CurrentCourse> CurrentCourses {get; set;}
        public IList<CourseRec> CourseRecs {get; set;}
        public IList<CourseWishList> CourseWishLists {get; set;}
    }

}