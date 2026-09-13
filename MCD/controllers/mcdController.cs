using Microsoft.AspNetCore.Mvc;

namespace MCD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class mcdController : ControllerBase
    {
        private readonly ILogger<mcdController> _logger;

        public mcdController(ILogger<mcdController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMCD")]
        public int Get(int a, int b)
        {
            return MCDCalculator.CalculateMCD(a, b);
        }
    }
}