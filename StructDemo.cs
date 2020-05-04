using System;
namespace basics
{
    struct StructsDS{
        private int empNo;
        private string lastName; //private by default
        private string firstName;
        static int lastEmpNo=1000;


        public static int GetNewEmpNum(){
            int localEmpNo=StructsDS.lastEmpNo+1;
            //Console.WriteLine("LastEmpNo: {0} and New Emp no: {1}",lastEmpNo,localEmpNo);
            StructsDS.lastEmpNo+=1;
            return localEmpNo;
        }
        public void setValues(int eNo,string fname,string lname){
            if(eNo>StructsDS.lastEmpNo){
                Console.WriteLine("Invalid eno");
            }
            else{
                empNo=eNo;
                firstName=fname;
                lastName=lname;
                Console.WriteLine(@"Successfully added employee
                Emp ID:{0}, First name: {1}
                Last Name: {2}" 
                , empNo,firstName,lastName);

            }}
            public void display(){
                    Console.WriteLine(@"Employee details:
                Emp ID:{0}, First name: {1}
                Last Name: {2}" 
                , empNo,firstName,lastName);
            }
        }
         public class StructDemo{

        public StructDemo(){
           StructsDS emp1=new StructsDS();
            StructsDS emp2=new StructsDS();

            Console.WriteLine("***************Structs  demo*********");
                int eNo=StructsDS.GetNewEmpNum();
                
                //Console.WriteLine("returned new empno: {0}",eNo);
                
                Console.WriteLine("Trying to insert employee details -1");
                emp1.setValues(eNo,"jai","sri");
                emp1.display();

                eNo=StructsDS.GetNewEmpNum();
                Console.WriteLine("Trying to insert employee details -2");
                emp2.setValues(eNo,"yazh","raj");
                emp2.display();
}
        }

    }
