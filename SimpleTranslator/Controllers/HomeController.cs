using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleTranslator.Models;

namespace SimpleTranslator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("Check")]
    public IActionResult Check()
    {
        return Ok("running");
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("/error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return NotFound("Request Error!");
    }
}
