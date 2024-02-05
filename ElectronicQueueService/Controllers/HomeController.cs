using System.Diagnostics;
using ElectronicQueueService.DB;
using Microsoft.AspNetCore.Mvc;
using ElectronicQueueService.Models;

namespace ElectronicQueueService.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Context _contextDb;
    
    public HomeController(ILogger<HomeController> logger, Context context)
    {
        _logger = logger;
        _contextDb = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    /*public IActionResult Privacy()
    {
        return View();
    }*/

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}