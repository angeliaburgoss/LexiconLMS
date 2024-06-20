namespace LexiconLMS.Models
{
    public class Document
    {
        public Guid DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public DateTime TimeStamp { get; set; }
        public int ModuleId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int ActivityId { get; set; }

    }
}
