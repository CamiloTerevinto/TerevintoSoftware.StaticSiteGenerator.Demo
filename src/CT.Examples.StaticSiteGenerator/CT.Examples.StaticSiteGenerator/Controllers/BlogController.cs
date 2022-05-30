using Microsoft.AspNetCore.Mvc;

namespace CT.Examples.StaticSiteGenerator.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("/Blog/Posts/MyFirstPost")]
    public IActionResult MyFirstPost()
    {
        return View("Views/Blog/Posts/MyFirstPost.cshtml");
    }
}
