using System.Collections.Generic;
namespace ClubTeamCourse {
    public class Course {
        public int CourseID {get; set;}
        public string CourseName {get; set;}
        public string CourseDays {get; set;}
        public string Prerequisite {get; set;}
        public string Description {get; set;}
        public int? GradeLevel {get; set;}
        public string CourseSubject {get; set;}
        public ICollection<CourseRec> CourseRecs {get; set;}
        public ICollection<CourseWishList> CourseWishLists {get; set;}
        public ICollection<CurrentCourse> CurrentCourses {get; set;}
    }
}