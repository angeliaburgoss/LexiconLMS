using Microsoft.AspNetCore.Mvc;
using LexiconLMS.Data;
using LexiconLMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LexiconLMSAPI.Api.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
        {
        private readonly ApplicationDbContext _context;

        public ActivitiesController(ApplicationDbContext context)
            {
            _context = context;
            }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
            {
            return await _context.Activities.ToListAsync();
            }
        }
    }
