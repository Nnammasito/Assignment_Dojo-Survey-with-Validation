using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment_Dojo_Survey_with_Validation.Models;

namespace Assignment_Dojo_Survey_with_Validation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("result")]
    public IActionResult Result(Survey survey)
    {
        if (ModelState.IsValid)
        {
            return View(survey);
        }
        else
        {
            return View("Index");
        }
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
