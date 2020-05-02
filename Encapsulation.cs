using System;
using System.Collections;
namespace basics
{
    class Encapsulation{
        private int empNo;
        string lastName; //private by default
        public string firstName;
        protected string email;
        internal long phoneNo;
        protected internal string nickName;

        const double salary=10000.00d;
        static int lastEmpNo=1000;


        ArrayList employees=new ArrayList();
        public int GetNewEmpNum(){
            empNo=Encapsulation.lastEmpNo+1;
            Encapsulation.lastEmpNo+=1;
            return empNo;
        }
        public void setValues(int eNo,string fname,string lname){
            if(eNo>Encapsulation.lastEmpNo){
                Console.WriteLine("Invalid eno");
            }
            else{
                firstName=fname;
                lastName=lname;
                Console.WriteLine(@"Successfully added employee
                Emp ID:{0}, First name: {1}
                Last Name: {2}, Salary: {3}" 
                , empNo,firstName,lastName,salary);

            }
        }
        public void EncapsulationDemo(){
                int eNo=GetNewEmpNum();
                Console.WriteLine("Trying to insert employee details with correct emp ID");
                setValues(eNo,"jai","sri");

                Console.WriteLine("Trying to insert employee details with incorrect emp ID");
                setValues(eNo+2,"yazh","raj");
        }

    }
}