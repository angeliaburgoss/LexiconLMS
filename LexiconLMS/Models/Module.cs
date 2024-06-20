namespace LexiconLMS.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CourseId { get; set; }
    }
}
