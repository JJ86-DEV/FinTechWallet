using Application.User.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
    
{
    [ApiController]
    [Route("api/[controller]")]     
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command) 
        {
            var userId = await _mediator.Send(command);

            return Ok(userId);
        }
    }
}
