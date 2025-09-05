using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using travelproject.Models;
using travelproject.Models.Classes;

namespace travelproject.Controllers;

public class MyBlogController : Controller

{

  private readonly Context _context;

  public MyBlogController(Context context)
  {

    _context = context;

  }
  public ActionResult Index()
  {
   var blogs = _context.MyBlog.ToList();
        return View(blogs);

    
  }

    public IActionResult MyBlogDetail(int id)
    {

        var blogs = _context.MyBlog.Where(b => b.ID == id).ToList();
return View(blogs);

    }
    }