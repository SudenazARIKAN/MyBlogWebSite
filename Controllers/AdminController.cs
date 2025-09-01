using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using travelproject.Models;

namespace travelproject.Controllers;

public class AdminController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
  }