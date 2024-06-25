namespace LexiconLMS.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime StartDate { get; set; }
        public int UserId { get; set; }
    }
}
