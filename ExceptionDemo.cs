using System;
namespace basics
{
    class InvalidNameException:Exception{
        public InvalidNameException(string msg):base(msg){

        }
    }
    class CustomerData{
        int[] luckNos=new int[2];
        string name;
        Random random=new Random();
        public void AddDetails(string name){
            Console.WriteLine("**Trying to add customer: {0}",name);
            try{
                if(name==null){
                    throw(new InvalidNameException("Customer name cannot be null!"));
                }
                else
                    this.name=name;
            
                //divide by zero
                int count=0,r=0;
                while(count<=2) //index =2 will raise index out of bounds exception
                {
                    try{
                    r=10/random.Next(0,2); // divide by zero
                    }
                    catch(DivideByZeroException e){
                    Console.WriteLine("DivideByZeroException: {0} \t so assign default value 1",e.Message);
                    r=1;
                    }
                    try{ 
                    luckNos[count]=r; //index =3 will raise index out of bounds exception
                    }
                    catch(IndexOutOfRangeException e){
                         Console.WriteLine("IndexOutOfRangeException: {0}",e.Message);
                    }

                count++;
                }

            }
            catch(InvalidNameException e){
                Console.WriteLine("InvalidNameException: {0}",e.Message);
            }
            
            catch(Exception e){
                Console.WriteLine("Exception: {0}",e.Message);
            }
        }
    }
    public class ExceptionDemo{

    public ExceptionDemo(){
        Console.WriteLine("*******Exception Demo*********");
          CustomerData customerData1=new CustomerData();
            CustomerData customerData2=new CustomerData();
            customerData1.AddDetails("jai");
            customerData2.AddDetails(null);
    }



    }
}