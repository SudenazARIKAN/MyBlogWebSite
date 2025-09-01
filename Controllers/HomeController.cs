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
        // Tüm liste
        var allBlogs = _context.MyBlog.OrderByDescending(x => x.ID).ToList();

        var lastThreeBlogs = _context.MyBlog
                                      .OrderBy(x => x.ID) // küçük ID’li ilk bloglar
                                      .Take(3)
                                      .ToList();




        var model = new MyIndexViewModel
        {
            AllBlogs = allBlogs,
            LastThreeBlogs = lastThreeBlogs
        };
        return View(model);
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

    public PartialViewResult Partial2()
    {
        var values = _context.MyBlog.OrderByDescending(x => x.ID).Take(10).ToList();
        return PartialView(values);
    }
        
          public PartialViewResult Partial3()
    {
        var values = _context.MyBlog.OrderByDescending(x => x.ID).Take(6).ToList();
        return PartialView(values);
        }
}
