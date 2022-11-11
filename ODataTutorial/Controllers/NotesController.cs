using Microsoft.AspNetCore.Mvc;

namespace ODataTutorial.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}