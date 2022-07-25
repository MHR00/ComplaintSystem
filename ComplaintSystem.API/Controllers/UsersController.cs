using ComplaintSystem.Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplaintSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserModel>> GetUsers()=>
            await _userService.GetUsers();

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(int id)
        {
            var results = await _userService.GetUser(id);
            if (results == null) return NotFound();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult> InserUser(UserModel user)
        {
            await _userService.InsertUser(user);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> UpdateUser(UserModel user)
        {
            await _userService.UpdateUser(user);
            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUser(id);
            return Ok();
        }
       

        


        
    }
}
