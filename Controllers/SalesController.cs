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
        List<Customer> cust = new List<Customer>();
        // for (int i =0; i < 10; i++){
        //     cust.Add(new Customer(){
        //         Id = i,
        //         Name = "Serhat" + i,
        //         Income = i*125
        //     });
        // }
        return View("DataList", cust);
    }
}
