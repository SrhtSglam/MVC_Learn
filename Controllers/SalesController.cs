using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Learn.Models;

namespace MVC_Learn.Controllers;

public class SalesController : Controller
{


    public IActionResult Index()
    {
        return View();
    }
    public IActionResult DataList()
    {
        string name = "Serhat";
        
        return View("DataList", name);
    }
}
