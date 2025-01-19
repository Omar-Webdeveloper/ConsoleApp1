using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int myInt = 9;
            //double myDouble = myInt;  // Automatic casting: int to double

            //double myDouble1 = 9.78;
            //int myInt1 = (int)myDouble1;  // Manual casting: double to int

            double l = 9223372036854775807;  // Maximum value for a long
            //int i = l;  

            // To make this work, you'd need explicit casting
            int i1 = (int)l;  // Explicit casting, but this may cause overflow
            Console.WriteLine(i1);


            //Console.WriteLine(myInt);
            //Console.WriteLine(myDouble);



            //Console.WriteLine(myDouble1.GetType());
            //Console.WriteLine(myInt1.GetType());

            //string s = "123"; 
            //int i = Convert.ToInt32(s); // Converts string to integer
            //Console.WriteLine(i.GetType()); // Output: 123



            //string s = "456.78";
            //double d = double.Parse(s); // Converts string to double
            //Console.WriteLine(d.GetType()); // Output: 456.78
        }
    }
}
