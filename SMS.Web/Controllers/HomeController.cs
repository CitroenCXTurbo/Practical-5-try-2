using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // add two new properties to the view bag named
        // - LongTime: Containing the current date/time formatted to a LongTimeString
        // - Message: Containing the text "Time Now"

        var longtime = DateTime.Now.ToShortDateString();
        var scriptmessage = "The Time now is: ";


        ViewBag.LongTime = longtime;
        ViewBag.ScriptMessage = scriptmessage;

        return View();
    }

    public IActionResult About()
    {
        var formed = new DateTime(1991,10,10);

        var about = new AboutViewModel{
            Formed = formed,
            Title = "View controller is the Title",
            Messageout = "A generic message out"
        };

        return View(about);
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
