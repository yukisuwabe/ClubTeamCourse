using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubTeamCourse {
    public class Student {
        [Required(ErrorMessage = "OSIS Required")]
        [Display (Name = "OSIS")]
        public int StudentID { get; set; }
        [Required(ErrorMessage = "First Name Required")]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        [Display (Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Grade Required")]
        [Display (Name = "Grade")]
        public int Grade { get; set; }
        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display (Name = "Email")]
        public string Email { get; set; }
        [Required (ErrorMessage = "Password Required")]
        [Display (Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Gender Required")]
        [Display (Name = "Gender")]
        public string Gender { get; set; }
        [Display (Name = "Favorite Subject")]
        public string FavoriteSubject { get; set; }
        [Display (Name = "Profile Picture")]
        public byte[] ProfilePic { get; set; }
        public ICollection<ClubRec> ClubRecs {get; set;}
        public ICollection<CourseRec> CourseRecs {get; set;}
        public ICollection<CourseWishList> CourseWishLists {get; set;}
        public ICollection<CurrentClubs> CurrentClubs {get; set;}
        public ICollection<CurrentCourse> CurrentCourses {get; set;}
        public ICollection<CurrentTeam> CurrentTeams {get; set;}
        public ICollection<TeamWishList> TeamWishLists {get; set;}
    }
}