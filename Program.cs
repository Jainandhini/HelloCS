using System;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            
           //prog 1
           Hello h=new Hello();
            h.HelloDemo();  
            Console.Write("Press any key to continue, q to quit\n");
            if( Console.ReadLine()=="q"){
           return;}

        //prog 2
        Numbers n=new Numbers();
        n.NumbersDemo();
            Console.Write(" Press any key to continue, q to quit\n");
            if( Console.ReadLine()=="q"){
           return;}
        
        }
    }
}
