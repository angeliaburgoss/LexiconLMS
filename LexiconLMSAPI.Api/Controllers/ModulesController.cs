using Microsoft.AspNetCore.Mvc;
using LexiconLMS.Data;
using LexiconLMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace LexiconLMSAPI.Api.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesController : ControllerBase
        {
        private readonly ApplicationDbContext _context;

        public ModulesController(ApplicationDbContext context)
            {
            _context = context;
            }

        [HttpGet("{courseId}")]
        public async Task<ActionResult<IEnumerable<Module>>> GetModules(int courseId)
            {
            return await _context.Modules.Where(c => c.CourseId == courseId).ToListAsync();
            }
        }
    }