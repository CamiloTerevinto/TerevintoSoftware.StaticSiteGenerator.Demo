using Microsoft.AspNetCore.Mvc;

namespace CT.Examples.StaticSiteGenerator.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Post()
    {
        return View("~/Views/Blog/Posts/Post.cshtml");
    }
}
