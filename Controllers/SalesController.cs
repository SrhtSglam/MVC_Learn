using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Learn.Models;

namespace MVC_Learn.Controllers;

public class SalesController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

    static List<Customer> cust = new List<Customer>(); //if not static old data lose but static method true running application

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

    [HttpPost]
    public IActionResult Submit(string name, int income){
        cust.Add(new Customer(){
            Id = 1,
            Name = name,
            Income = income
        });
        ViewBag.Message = "MSG:" + cust.Count;
        return View("DataList", cust);
    }
}
