using Microsoft.EntityFrameworkCore;

namespace ClubTeamCourse
{
    public class ClubTeamManagement : DbContext
    {
        public DbSet<ClubCategory> ClubCategories {get; set;}
        public DbSet<ClubList> ClubList {get; set;}
        public DbSet<ClubRec> ClubRec {get; set;}
        public DbSet<Course> Course {get; set;}
        public DbSet<CourseRec> CourseRec {get; set;}
        public DbSet<CourseWishList> CourseWishList {get; set;}
        public DbSet<CurrentClubs> CurrentClubs {get; set;}
        public DbSet<CurrentCourse> CurrentCourse {get; set;}
        public DbSet<CurrentTeam> CurrentTeam {get; set;}
        public DbSet<Team> Team {get; set;}
        public DbSet<TeamWishList> TeamWishList {get; set;}
        public DbSet<Student> Student {get; set;}
        public ClubTeamManagement(DbContextOptions<ClubTeamManagement> options) : base(options) {}
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClubCategory>().Property(c => c.CategoryName).IsRequired();
            modelBuilder.Entity<ClubCategory>().HasMany(c => c.ClubList).WithOne(p => p.Category);
            modelBuilder.Entity<Student>().HasMany(c => c.CurrentCourses).WithOne(p => p.Student);
            modelBuilder.Entity<Student>().HasMany(c => c.CourseWishLists).WithOne(p => p.Student);
            modelBuilder.Entity<Student>().HasMany(c => c.CourseRecs).WithOne(p => p.Student);
            modelBuilder.Entity<Student>().HasMany(c => c.CurrentTeams).WithOne(p => p.Student);
            modelBuilder.Entity<Student>().HasMany(c => c.TeamWishLists).WithOne(p => p.Student);
            modelBuilder.Entity<Student>().HasMany(c => c.ClubRecs).WithOne(p => p.Student);
            modelBuilder.Entity<Student>().HasMany(c => c.CurrentClubs).WithOne(p => p.Student);
            modelBuilder.Entity<Course>().HasMany(c => c.CurrentCourses).WithOne(p => p.Course);
            modelBuilder.Entity<Course>().HasMany(c => c.CourseWishLists).WithOne(p => p.Course);
            modelBuilder.Entity<Course>().HasMany(c => c.CourseRecs).WithOne(p => p.Course);
            modelBuilder.Entity<Team>().HasMany(c => c.CurrentTeams).WithOne(p => p.Team);
            modelBuilder.Entity<Team>().HasMany(c => c.TeamWishLists).WithOne(p => p.Team);
            modelBuilder.Entity<ClubList>().HasMany(c => c.CurrentClubs).WithOne(p => p.Club);
            modelBuilder.Entity<ClubList>().HasMany(c => c.ClubRec).WithOne(p => p.Club);
            modelBuilder.Entity<ClubList>().Property(c => c.ClubID).IsRequired();
            modelBuilder.Entity<CurrentCourse>().HasKey(od => new {od.StudentID, od.CourseID});
            modelBuilder.Entity<CourseRec>().HasKey(od => new {od.StudentID, od.CourseID});
            modelBuilder.Entity<CourseWishList>().HasKey(od => new {od.StudentID, od.CourseID});
            modelBuilder.Entity<CurrentClubs>().HasKey(od => new {od.StudentID, od.ClubID});
            modelBuilder.Entity<CurrentTeam>().HasKey(od => new {od.StudentID, od.TeamID});
            modelBuilder.Entity<TeamWishList>().HasKey(od => new {od.StudentID, od.TeamID});
            modelBuilder.Entity<ClubRec>().HasKey(od => new {od.StudentID, od.ClubID});
        }
    }
}
