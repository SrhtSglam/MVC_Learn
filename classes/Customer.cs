using System;

namespace MVC_Learn;

public class Customer{
    public Customer(){
        Name = "";
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Income { get; set; } 
}