using Microsoft.AspNetCore.Mvc;

namespace ExerciseManning.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly ILogger<ExerciseController> _logger;

        public ExerciseController(ILogger<ExerciseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Exercise> Get()
        {
            return new[]
            {
                new Exercise
                {
                    Id = 0,
                    Name = "Exc1",
                    Year = 2000,
                    MinPlayers = 2,
                    MaxPlayers = 4
                },

                new Exercise
                {
                    Id = 1,
                    Name = "Exc2",
                    Year = 2004,
                    MinPlayers = 4,
                    MaxPlayers = 6
                },

                new Exercise
                {
                    Id = 2,
                    Name = "Exc1",
                    Year = 2010,
                    MinPlayers = 6,
                    MaxPlayers = 12
                }
            };
        }
    }
}
