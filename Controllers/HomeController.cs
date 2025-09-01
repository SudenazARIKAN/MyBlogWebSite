using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using travelproject.Models;
using travelproject.Models.Classes;

namespace travelproject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Context _context;

    public HomeController(ILogger<HomeController> logger, Context context)
    {
        _logger = logger;
        _context = context;

    }

    public IActionResult Index()
    {
        var degerler = _context.MyBlog.ToList();
        return View(degerler);
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

    public IActionResult About()
    {
        var values = _context.Abouts.ToList();
        return View(values);

    }
    public IActionResult MyBlog()
    {
        var blogs = _context.MyBlog.ToList();
        return View(blogs);
    }

    public IActionResult MyBlogDetail(int id)
    {

        var blog = _context.MyBlog.FirstOrDefault(b => b.ID == id);
        if (blog == null) return NotFound();

        return View(blog);
    }
    public PartialViewResult Partial1()
    {
        var values = _context.MyBlog.OrderByDescending(x => x.ID).Take(3).ToList();
        return PartialView(values);
        }
}
