using System;
namespace basics
{
    class TypeConversion{
        public void TypeConversionDemo(){
            Console.WriteLine("Enter int number : ");
           int a= Convert.ToInt16(Console.ReadLine());
           Console.WriteLine("Integer: {0}, integer squared: {1} ",a,a*a);
           Console.WriteLine("Enter a char: ");
           char s= Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Char: {0}, Char value: {1}",s,(int)s);

        }
    
    }
}