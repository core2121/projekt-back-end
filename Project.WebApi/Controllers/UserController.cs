using Microsoft.AspNetCore.Mvc;
using Project.WebApi.Models;

namespace Project.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IEnumerable<User> GetUsers()
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {
                Name = $"NameP{index}",
                Surname = $"Surname{index}"
            })
            .ToArray();
        }

        [HttpPost]
        [Route("PostRegisterUser")]
        public IActionResult PostRegisterUser([FromBody] User user)
        {
            return Ok();
        }
    }
}