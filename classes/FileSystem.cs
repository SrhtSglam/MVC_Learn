using System;
using MVC_Learn.Controllers;
using Newtonsoft.Json;

namespace MVC_Learn;

public class FileSystem(){

    public void fileWrite(List<Customer> lst){
        string filePath = "json/dtbUsers.json";
        string json = JsonConvert.SerializeObject(lst);
        File.WriteAllText(filePath, json);
    }

    public List<Customer> fileRead(List<Customer> lst){
        string filePath = "json/dtbUsers.json";
        string json = File.ReadAllText(filePath);
        lst = JsonConvert.DeserializeObject<List<Customer>>(json)!;
        return lst;
    }
}