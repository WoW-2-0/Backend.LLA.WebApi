using Microsoft.AspNetCore.Mvc;

namespace Versioning.WithRouting.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllUsersAsync() =>
        Ok(new[]
        {
            new
            {
                UserId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe"
            },
            new
            {
                UserId = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Doe"
            }
        });
}