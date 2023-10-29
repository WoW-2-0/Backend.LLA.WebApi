using System.IO.Pipelines;
using Microsoft.AspNetCore.Mvc;

namespace Versioning.WithHeaders.Controllers.V1;

[ApiController]
[ApiVersion("1.0", Deprecated = true)]
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