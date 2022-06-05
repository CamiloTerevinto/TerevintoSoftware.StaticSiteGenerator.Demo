using Microsoft.AspNetCore.Mvc;

namespace CT.Examples.StaticSiteGenerator.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
