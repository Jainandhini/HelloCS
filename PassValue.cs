using System;
namespace basics
{
    class PassValue{

        public void PassByValue(int a, int b){
            Console.WriteLine("PassByValue Sum of {0} and {1}: {2}",a,b,a+b);
        }
        public void PassByPointer(ref int a, ref int b){
            Console.WriteLine(@"PassByPointer Values modified by reference
            Before a: {0} b:{1}",a,b);
            a=a*5;
            b=b*10;
        }
        public void PassByOutputParam(out int? a){
            Console.WriteLine("PassByOutputParam Values modified by output param ");
            a=new int?();
            //nullable coalesce
            a=a??1000;
        }
        public void PassValueDemo(){
            Console.WriteLine("*********PassValueDemo*************");
            PassByValue(5,10);
            int a=5,b=10;
            PassByPointer(ref a,ref b);
            Console.WriteLine(@"After a: {0} b:{1}",a,b);
            //nullable int
            int? x=null;
            Console.WriteLine(@"PassByOutputParam 
             Before x: {0}",x);
            PassByOutputParam(out x);
            Console.WriteLine(@"After x: {0}",x);
        }
    }
    
}