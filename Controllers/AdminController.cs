using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using travelproject.Models;
using travelproject.Models.Classes;

namespace travelproject.Controllers;

public class AdminController : Controller

{

  private readonly Context _context;

  public AdminController(Context context)
  {

    _context = context;

  }
  public ActionResult Index()
  {
    var model = new MyIndexViewModel
    {
      AllBlogs = _context.MyBlog.ToList(),
      LastSixBlogs = _context.MyBlog.OrderByDescending(x => x.ID).Take(6).ToList()
    };

    return View(model);
  }
  [HttpGet]
  public ActionResult NewBlog()
  {
    return View();
  }
  [HttpPost]
  public ActionResult NewBlog(MyBlog p)
  {
    _context.MyBlog.Add(p);
    _context.SaveChanges();
    return RedirectToAction("Index");
  }
  public ActionResult DeleteBlog(int id)
  {
    var b = _context.MyBlog.Find(id);
    _context.MyBlog.Remove(b);
    _context.SaveChanges();
    return RedirectToAction("Index");

  }
  
   public ActionResult GetBlog(int id)
  {
    var bl = _context.MyBlog.Find(id);
    return View("GetBlog", bl);

  }

}