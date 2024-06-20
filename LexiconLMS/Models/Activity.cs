using Microsoft.AspNetCore.Routing.Constraints;

namespace LexiconLMS.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int ModuleId { get; set; }
    }
}
