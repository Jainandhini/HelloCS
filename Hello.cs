using System;
namespace basics{
class User{
   
    public void welcomeUser(String name){
        Console.WriteLine("Welcome to my repo, dear "+name+" !!");
    }
}
class Hello{
    
    public void HelloDemo(){
        String name;
        User user=new User();
        Console.WriteLine("*********Hello World************");
        Console.Write("Hello this is jai!");
        Console.WriteLine("\tWhat is your name? ");
        name=Console.ReadLine();
        user.welcomeUser(name);
        
       
    }
}
}
