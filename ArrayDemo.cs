using System;
namespace basics
{
    class ArrayDemo{

        public  ArrayDemo(){
            Console.WriteLine("*****Arrays Demo*******");
            Console.WriteLine("One dimensional Array");
            int[] oneDArray=new int[5]{2,8,6,4,9};
            foreach(int i in oneDArray){
                Console.Write("\t {0}",i);
            }
            Console.WriteLine("\n2D array\n");
            int[,] twoDArray=new int[2,5]{{2,5,6,7,9},{1,3,5,7,8}};
            for(int i=0;i<2;i++){
                for(int j=0;j<5;j++)
                {
                Console.Write("\t Index:{0}{1}, Value: {2}",i,j,twoDArray[i,j]);
            }
            Console.Write("\n");
            }
            Console.WriteLine("\nJagged Array\n");//uneven no of columns
            string[][] jaggedArray=new string[2][]
            {
                new string[]{"dad","mom","baby"},
                new string[]{"grandpa","grandma"}
            };
            for(int i=0;i<jaggedArray.Length;i++){
                for(int j=0;j<jaggedArray[i].Length;j++)
                {
                Console.Write("\t Index:{0}{1}, Value: {2}",i,j,jaggedArray[i][j]);
            }
            Console.Write("\n");
            }
            Console.WriteLine("\nPassing array to methods");
                printArray(oneDArray);

            Console.WriteLine("\nCommon array functions");
            Console.WriteLine("\nSorted Array");
            Array.Sort(oneDArray);
            foreach(int i in oneDArray){
                Console.Write("\t {0}",i);
            }
            Console.WriteLine("\nReverse Array");
            Array.Reverse(oneDArray);
            foreach(int i in oneDArray){
                Console.Write("\t {0}",i);
            }
            Console.WriteLine("\nIndex of 6 is: {0}",Array.IndexOf(oneDArray,6));
            Console.WriteLine("Length of array is GetLength: {0}, Length param: {1}",oneDArray.GetLength(0),oneDArray.Length);
            Console.WriteLine("Array dimension is {0}",oneDArray.Rank);
           

        }
        public void printArray(int[] nos){
            Console.WriteLine("Printing array passed to the method");
            foreach (int i in nos)
                Console.Write("\t {0}",i);
                
        }
    }
}