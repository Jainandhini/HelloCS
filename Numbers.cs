using System;
namespace basics{
    class Numbers{
        int intNum;

        float floatNum; //suffix with f
        double dNum;
        decimal deciNum; //currency


        char charType; 
        String textObj;
        string text; //preferred in c#

        bool boolType;

        
        
        public Numbers(){}
        Numbers(String text){
            string defaultVar="";
            printNum(text,defaultVar);
        }
        void printNum(String welcomeText,String text1){
            var uniType=text1;
            Console.WriteLine("\n*********"+welcomeText+"*********");
            Console.WriteLine("Int: "+intNum);
            Console.WriteLine("float: "+floatNum);
            Console.WriteLine("double: "+dNum);
            Console.WriteLine("decimal: "+deciNum);
            Console.WriteLine("char: "+charType+" and its int value: "+(int)charType);
            Console.WriteLine("String primitive : "+text);
            Console.WriteLine("String obj: "+textObj);
            Console.WriteLine("Boolean: "+boolType);
            Console.WriteLine("var type: "+uniType);
        }
        void setSomeValues(){
            
            intNum=10;
            floatNum=10.1f;
            dNum=11.25;
            deciNum=(decimal)1000000.0000025;
            charType='j';
            text="jai";
            textObj="yazh";
            boolType=true;
            //uniType="hi";
        }
        public void NumbersDemo(){
            
            Console.WriteLine("******Variable Types Demo******");
            Numbers ns=new Numbers("Default values:");
            ns.setSomeValues();
            ns.printNum("New Values","hi");
            
       
        }
    }
}

