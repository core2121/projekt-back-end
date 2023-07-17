using Microsoft.AspNetCore.Mvc;
using OA.Data;
using OA.Service;
using Project.WebApi.Models;
using System;

namespace Project.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserRoleService _userRoleService;
        private readonly IUserPrivilagesService _userPrivilagesService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService userService, IUserRoleService userRoleService, IUserPrivilagesService userPrivilagesService, ILogger<UserController> logger)
        {
            _userService = userService;
            _userRoleService = userRoleService;
            _userPrivilagesService = userPrivilagesService;

            _logger = logger;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetAll();
        }

        [HttpPost]
        [Route("PostRegisterUser")]
        public IActionResult PostRegisterUser([FromBody] UserModel model)
        {
            var ur = _userRoleService.GetById(model.UserRole);

            if (ur == null)
                return BadRequest();

            var up = _userPrivilagesService.GetById(model.UserPrivilages);

            if (up == null)
                return BadRequest();

            var u = new OA.Data.User()
            {
                Name = model.Name,
                Surname = model.Surname,
                Login = model.Login,
                Password = model.Password
            };

            u.UserRole = ur;
            u.UserPrivilages = up;

            var errorMessage = _userService.InsertUser(u);

            if (errorMessage != string.Empty)
                return BadRequest();

            return Ok();
        }
    }
}