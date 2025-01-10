using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutApplication.Controllers
{  
    [ApiController]
    [Route("api/[controller]")]
    public class ExercisesController : ControllerBase
    {
        private readonly DataContext _context;
        
        public ExercisesController(DataContext _context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetExercises()
        {
            return Ok(_context.ExerciseList);
        }   
    }
}