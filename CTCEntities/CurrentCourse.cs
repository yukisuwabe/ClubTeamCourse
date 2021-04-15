namespace ClubTeamCourse {
    public class CurrentCourse {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Student Student {get; set;}
        public Course Course {get; set;}
    }
}