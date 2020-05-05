using System;
using System.Collections;
namespace basics{

    interface ISubscription{
        public void AddSubscription();
        public void RemoveSubscription();
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
        string[] ott=new string[3]; //using simple array to hold list of data
        int count=0; 
        //enum channels {Netflix=1,Hulu,Prime};
        public OTTCustomer():base(){
            
            Console.WriteLine("Inside child: OTTCustomer");
        }
        public void AddSubscription(){
            Console.WriteLine("**Add OTT Subscription**");
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
        public void RemoveSubscription(){}
        public override void display(){
            Console.WriteLine("OTT subscribed to by the customer {0}",name);
                foreach(string s in ott){
                    Console.WriteLine(s);
                }
        }
        //polymorphism example with same method name and diff args
        public void display(String msg){
                Console.WriteLine(msg);
        }
    }
     class PodcastList: Customer,ISubscription{
        ArrayList plist=new ArrayList(); //using Collections list to hold list of data
        const string spotify="Spotify";
        const string audible="Audible";
        const string google="Google Podcasts";
        public PodcastList(){
            Console.WriteLine("Inside podcast constructor");
        }
        public string getUserChoice(ref int option){
            string choice="";
            Console.WriteLine("\n1.Spotify 2.Audible 3.Google Podcasts 4.Exit Menu \nEnter your option: ");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    choice=spotify; break;
                case 2:
                    choice=audible; break;
                case 3:
                    choice=google; break;}
            return choice;
        }
        public void AddSubscription(){
            Console.WriteLine("**Add Podcast Subscription**");
            string choice;
            int option=0;
            do{
                    choice=getUserChoice(ref option);
                    if(choice!=""){
                    plist.Add(choice);
                    Console.WriteLine("{0} has been added!",choice);
                    }
            }while(option!=4);
            
        }
        public void RemoveSubscription(){
            Console.WriteLine("**Remove Podcast Subscription**");
            string choice;
            int option=0;
            do{
                    choice=getUserChoice(ref option);
                    if(choice!=""){
                    plist.Remove(choice);
                    Console.WriteLine("{0} has been removed!",choice);
                    }
            }while(option!=4);
            
        }
            
        public override void display(){
            Console.WriteLine("Podcast subscribed to by the customer {0}",name);
                foreach(string s in plist){
                    Console.WriteLine(s);
                }
        }
        public void display(String msg){
                Console.WriteLine(msg);
        }
    }
    public class CustomerDemo{
            public CustomerDemo(){
                Customer customer;
                Console.WriteLine("***************Customer  demo- Inheritance,Polymorphism,Interface*********");
                OTTCustomer oTT=new OTTCustomer();
                customer=oTT; //runtime polymorphism
                oTT.display("Welcome to OTT subscription services");
                oTT.AddSubscription();
                customer.display();
                oTT.display("Thank you!!");

                PodcastList podcastList=new PodcastList();
                customer=podcastList;
                podcastList.AddSubscription();
                customer.display(); //runtime polymorphism
                podcastList.RemoveSubscription();
                customer.display();
                podcastList.display("Thank you!!");



            }
    }
}