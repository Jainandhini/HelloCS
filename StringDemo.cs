using System;
namespace basics
{
    class StringDemo{

public StringDemo(){
        string fname="Jainandhini";
        string lname=new string("srinivasan");
        char [] n={'j','a','i'};
        string nick=new string(n);
        string fullName=String.Join(fname," "+lname);

        Console.WriteLine(@"*********String Demo*******
        First name: {0}
        Last name: {1}
        nick name: {2}
        full name: {3}
        ",fname,lname,nick,fullName);
        Console.WriteLine("String.Compare(\"jai\",\"raj\"): {0}",String.Compare("jai","raj"));
        Console.WriteLine("fname.CompareTo(\"raj\"): {0}",fname.CompareTo("raj"));
        Console.WriteLine("fname.Equals(\"raj\"): {0}",fname.Equals("raj"));
        Console.WriteLine("fname.IndexOf('a'): {0} ",fname.IndexOf('a'));
        Console.WriteLine("fname.Contains('J'): {0} ",fname.Contains('J'));
        Console.WriteLine("lname.Length: {0}",lname.Length);
        Console.WriteLine();

}        

    }
}