using Microsoft.AspNetCore.Mvc;

namespace chrsolr_api.Controllers;

[ApiController]
[Route("api/v1/about")]
public class AboutController : ControllerBase
{
    private readonly ILogger<AboutController> _logger;
    private readonly IAboutService _aboutService;

    public AboutController(ILogger<AboutController> logger, IAboutService aboutService)
    {
        _logger = logger;
        _aboutService = aboutService;
    }

    [HttpGet]
    public async Task<ActionResult<AboutDTO>> Get()
    {
        var about = await _aboutService.GetAboutMe();
        if (about is null)
        {
            return NotFound();
        }

        return Ok(about);
    }
}
