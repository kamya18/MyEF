// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyEF.Data;
using MyEF.Models;
class Program{
    static void Main(){
        using(var context=new MyDBContext()){
            var newUser=new User();
            // newUser.Id=1;
            newUser.Name="Mitanshu";
            context.Users.Add(newUser);
            context.SaveChanges();
            Console.WriteLine("Creating user data!");
            Console.WriteLine("Reading data and printing below!");
            var users=context.Users.ToList();
            foreach(var user in users){
                Console.WriteLine($"ID: {(user.Id)}, Name: {user.Name}");
            }
            var oldUser=context.Users.FirstOrDefault(u=>u.Name=="Mitanshu");
            if(oldUser!=null){
                oldUser.Name="Mitanshu_1";
                Console.WriteLine("User updated successfully!");
            }
            foreach(var user in users){
                Console.WriteLine($"ID: {(user.Id)}, Name: {user.Name}");
            }
        }
    }
}


