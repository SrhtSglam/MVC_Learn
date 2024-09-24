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
        List<string> lst = new List<string>();
        for (int i =0; i < 10; i++){
            lst.Add("SERhat" + i);
        }
        return View("DataList", lst);
    }
}
