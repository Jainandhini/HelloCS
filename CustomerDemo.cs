using System;
namespace basics{

    interface ISubscription{
        public void AddSubscription();
    }
    abstract class Customer{
        protected string name;
        public Customer(){
            Console.WriteLine("Inside parent: Customer");
        }

        abstract public void display();
    }
    class OTTCustomer:Customer,ISubscription{

        const string Netflix="Netflix";
        const string Hulu="Hulu";
        const string Prime="Prime";
        string[] ott=new string[3];
        int count=0; 
        //enum channels {Netflix=1,Hulu,Prime};
        public OTTCustomer():base(){
            
            Console.WriteLine("Inside child: OTTCustomer");
        }
        public void AddSubscription(){
            int option;
            string choice;
            do{
                choice="";
            Console.WriteLine("\n1.Netflix 2.Hulu 3.Prime 4.Exit Menu \nEnter your option: ");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    choice=Netflix; break;
                case 2:
                    choice=Hulu; break;
                case 3:
                    choice=Prime; break;
            }
            if(choice!=""){
                ott[count]=choice;
                count++;
                Console.WriteLine("{0} has been added!",choice);
                }
            }while(option!=4 &&count<3);
            
            
        }
        public override void display(){
            Console.WriteLine("OTT subscribed to by the customer {0}",name);
                foreach(string s in ott){
                    Console.WriteLine(s);
                }
        }
        public void display(String msg){
                Console.WriteLine(msg);
        }
    }
    public class CustomerDemo{
            public CustomerDemo(){
                Console.WriteLine("***************Customer  demo- Inheritance,Polymorphism,Interface*********");
                OTTCustomer oTT=new OTTCustomer();
                oTT.display("Welcome to OTT subscription services");
                oTT.AddSubscription();
                oTT.display();
                oTT.display("Thank you!!");


            }
    }
}