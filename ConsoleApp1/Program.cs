using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create console application that read string from user and print the same string
            Console.WriteLine("Task 1");

            string read_line = Console.ReadLine();
            Console.WriteLine(read_line);
            Console.WriteLine("");

            //2 - Define variables with kind of
            //a.Double
            //b.String
            //c.Char
            //d.Bool
            //e.Int
            //f.Const
            //Then display it in console application
            Console.WriteLine("Task 2");

            double number_1 = 1;
            string text = "my text";
            char letter ='A';
            bool isTrue = false;
            int number_2 = 2;
            const int number_3 = 3;

            Console.WriteLine(number_1);
            Console.WriteLine(text);
            Console.WriteLine(letter);
            Console.WriteLine(isTrue);
            Console.WriteLine(number_2);
            Console.WriteLine(number_3);




            //3 - Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            Console.WriteLine("Task 3");
            string[] cars = {"BMW","MERCEDES BENZ","FORD","SAAB","LADA" };
            Console.WriteLine(cars.Length);
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }



            //4 - Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially.Go to the editor
            //    •	Input your firstname: Sami
            //    •	Input your lastname: Ali
            //    •	Input your year of birth: 1999
            //    •	Sami Ali 1999
            Console.WriteLine("Task 4");
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string year_of_birth = Console.ReadLine();

            Console.WriteLine(firstname + lastname + year_of_birth);



            //5 - Write a program in C # to store elements in an array and print it. 
            //    •	Test Data :	
            //    •	Input 10 elements in the array :
            //    •	element - 0 : 1
            //    •	element - 1 : 1
            //    •	element - 2 : 2
            //    •	.......
            //    •	Expected Output :
            //    •	Elements in array are: 1 1 2 3 4 5 6 7 8 9



        }
    }
}
