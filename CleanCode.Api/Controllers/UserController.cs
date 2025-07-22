using CleanCode.Core.Entities;
using CleanCode.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanCode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) {
            this._userService = userService;
        }

        [HttpGet]
        public async Task<List<UserEntity>> GetAll()
        {
            return await _userService.GetAll();
        }
    }
}
