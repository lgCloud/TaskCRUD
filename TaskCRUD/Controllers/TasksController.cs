using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskCRUD.Controllers
{
    [ApiController]
    [Route("tasks")]
    public class TasksController : ControllerBase
    {
        private readonly TasksContext _context;

        public TasksController(TasksContext context)
        {
            _context = context;
        }
        // localhost:5000/WeatherForecast METHOD: GET
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _context.Tasks.ToListAsync();
            if (result.Any()) return Ok(result);
            return NotFound();
        }

    }
}
