using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using E_Ticaret_Poroje.Models;

namespace E_Ticaret_Poroje.Controllers;

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

    [Route ("/shop")]
    public IActionResult Shop()
    {
        return View();
    }

    [Route ("/blog")]
    public IActionResult Blog()
    {
        return View();
    }

     [Route ("/contact")]
    public IActionResult Contact()
    {
        return View();
    }

    [Route ("/login")]
    public IActionResult Login()
    {
        return View();
    }

    [Route ("/register")]
    public IActionResult Register()
    {
        return View();
    }

     [Route ("/about")]
    public IActionResult About()
    {
        return View();
    }

    [Route ("/faq")]
    public IActionResult Faq()
    {
        return View();
    }

    [Route ("/checkout")]
    public IActionResult Checkout()
    {
        return View();
    }

    
    [Route ("/admin")]
    public IActionResult Admin()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
