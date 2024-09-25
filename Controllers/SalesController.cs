using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileSystemGlobbing;
using MVC_Learn.Models;
using Newtonsoft.Json;

namespace MVC_Learn.Controllers;

public class SalesController : Controller
{


    //public static List<Customer> customerList; = new List<Customer>(); //if not static old data lose but static method true running application
    public List<Customer> customerList;
    FileSystem fs = new FileSystem();
    public SalesController()
    {
       if (customerList == null) {
            customerList = new List<Customer>();
        } 
    }

    public IActionResult Index()
    {
        return View();
    }

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

        if (customerList == null) {
            customerList = new List<Customer>();
        } 

        return View("DataList", customerList);
    }



    [HttpPost]
    public IActionResult DataListPost(string name, int income){
        
        
        // ViewBag.Message = "MSG:" + cust.Count;
        customerList = fs.fileRead();
        customerList.Add(new Customer(){
            Id = i++,
            Name = name,
            Income = income
        });

        fs.fileWrite(customerList);
        
        customerList = fs.fileRead();
        return View("DataList", customerList);
    }

    [HttpGet]
    public IActionResult GetList(){
        //fs.fileRead(cust);

        /*if (customerList == null) {
            customerList = new List<Customer>();
        } */

        customerList =  fs.fileRead();
        return View("DataList", customerList);

    }

    
    [HttpGet]
    public IActionResult GetList2(string name, int income){
        // ViewBag.Message = "MSG:" + cust.Count;
        //cust = fs.fileRead(cust);
        customerList = fs.fileRead();
        
        return View("DataList", customerList);
    }


    
}
