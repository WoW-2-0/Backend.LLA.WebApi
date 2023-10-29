using Microsoft.AspNetCore.Mvc;

namespace Versioning.WithHeaders.Controllers.V2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllUsersAsync() =>
        Ok(new[]
        {
            new
            {
                UserId = Guid.NewGuid(),
                FullName = "John Doe"
            },
            new
            {
                UserId = Guid.NewGuid(),
                FullName = "Jane Doe"
            }
        });
}