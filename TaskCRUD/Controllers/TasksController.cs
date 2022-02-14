using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskCRUD.Model;

namespace TaskCRUD.Controllers
{
    [ApiController]
    [Route("tasks")]
    public class TasksController : ControllerBase
    {
        public TasksController()
        {
        }
        // localhost:5000/WeatherForecast METHOD: GET
        [HttpGet]
        public Task Get()
        {
            return new Task
            {
                Description = "testing task description",
                Title = "testing task"
            };
        }

    }
}
