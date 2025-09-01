using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using travelproject.Models;

namespace travelproject.Controllers;

public class DefaultController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult About()
    {
        return View();
    }
    
    public ActionResult MyBlog()
    {
        return View();
    }
 public ActionResult MyBlogDetail()
    {
        return View();
    }

 }