using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ahlers_Michael_Assignment_6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;
        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public MyName Get()
        {
            return new MyName { Name = "Michael Ahlers" };
        }
    }
}
