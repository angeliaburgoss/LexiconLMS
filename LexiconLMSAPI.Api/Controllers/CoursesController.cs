using Microsoft.AspNetCore.Mvc;
using LexiconLMS.Data;
using LexiconLMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LexiconLMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase 
    {
       private readonly ApplicationDbContext _context;
        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
                }
        [HttpGet]
        public async Task<ActionResult<Course>> GetCourses()
        {
            var courses =  await _context.Courses.ToListAsync();
            return Ok(courses);
        }
    }
}
