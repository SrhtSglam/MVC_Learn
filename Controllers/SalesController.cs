using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileSystemGlobbing;
using MVC_Learn.Models;
using Newtonsoft.Json;

namespace MVC_Learn.Controllers;

public class SalesController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

    public static List<Customer> cust = new List<Customer>(); //if not static old data lose but static method true running application
    static int i = 0;

    public IActionResult DataList()
    {
        // for (int i =0; i < 10; i++){
        //     cust.Add(new Customer(){
        //         Id = i,
        //         Name = "Serhat" + i,
        //         Income = i*125
        //     });
        // }
        return View("DataList", cust);
    }

    FileSystem fs = new FileSystem();

    [HttpPost]
    public IActionResult DataListPost(string name, int income){
        cust.Add(new Customer(){
            Id = i++,
            Name = name,
            Income = income
        });
        // ViewBag.Message = "MSG:" + cust.Count;
        fs.fileWrite(cust);
        return View("DataList", cust);
    }

    [HttpGet]
    public IActionResult DataListGet(string name, int income){
        // ViewBag.Message = "MSG:" + cust.Count;
        cust = fs.fileRead(cust);
        return View("DataList", cust);
    }

    
}
