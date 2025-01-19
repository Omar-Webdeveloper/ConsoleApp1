using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    
    internal class Program
    {
        static void ToNumber(double x)
        {
            Console.WriteLine(" Input is Double =  " + x);
            int y = (int)x;
            Console.WriteLine(" Converted integer =" + y);


        }

        static void ToOtherStrings( int x)
        {
            string y = x.ToString();
            Console.WriteLine($"Output: Your number is: {y}");
        }

        static void print_captial_small_letter(string x)
        {
            string x2 = x.ToUpper();
            string x3 = x.ToLower();
            Console.WriteLine($" Uppercase:{x2} \n Lowercase:{x3}");
        }

        static void print_user_name(string x,string y)
        {
            Console.WriteLine($"First Name: {x} \n Last Name: {y} \n Total Characters: {(x.Length) +(y.Length)}");
        }


        static void small_number(int x ,int y)
        {
            Console.WriteLine($"Smaller numnber is {Math.Min(x, y)} ");
        }

        static void miles_per_hour(int x)
        {
            Console.WriteLine($"{x / 0.6213711922} mph ");
        }


        static void total_minutes(int x, int y)
        {
            Console.WriteLine($"{(x * 60) + y} minutes");
        }

        static void total_Hours_mintues(int x)
        {
            int hours = x / 60;
            int minutes= x % 60;
            Console.WriteLine($"{hours}hours,{minutes} minutes");
        }


        static void compare_two_number(int x, int y)
        {

            string result = (x > y) ? "Greater." : (x < y) ? "Smaller" : (x == y) ? "Equal" :"Something went wrong";
            Console.WriteLine(result);
     

        }
        static void Sum_Digits()
        { Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
        int sum = 0, reminder;
           
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }

    Console.WriteLine($"The Sum of Digits is : {sum}");}

static void reversed_number()
        {
            int num, rev = 0, rem;
            Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            Console.Write("Reverse of the Number: " + rev);
        }

        static void Check_Divisibility(int x, int y)
        {
            bool z = ((x % y) == 0); Console.WriteLine($" {x} is Divisible based on {y} the answer is {z}");
        }

        static void Middle_Value(int x, int y, int z)
        {
            bool A = (x > y && x < z) || (x < y && x > z);
            Console.WriteLine($"{x} is the middle number {A}"); 

            bool A1 = (x < y && y < z)|| (x > y && y > z);
            Console.WriteLine($"{y} is the middle number {A1}"); 

            bool A2 = (z > y && x > z)|| (z < y && x < z);
            Console.WriteLine($"{z} is the middle number {A2}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: ");
            double x = Convert.ToDouble(Console.ReadLine());
            ToNumber(x);

            Console.WriteLine("Task 2: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            ToOtherStrings(x1);

            Console.WriteLine("Task 3: ");
            string text = Console.ReadLine();
            print_captial_small_letter(text);

            Console.WriteLine("Task 4: ");
            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            print_user_name(first_name, last_name);


            Console.WriteLine("Task 5: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            int second_number = Convert.ToInt32(Console.ReadLine());
            small_number(first_number, second_number);


            Console.WriteLine("Task 6: ");
            int Kelo_meters = Convert.ToInt32(Console.ReadLine());
            miles_per_hour(Kelo_meters);


            Console.WriteLine("Task 7: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            total_minutes(hours, minutes);


            Console.Write("Task 8: ");
            int numbers_mintues = Convert.ToInt32(Console.ReadLine());
            total_Hours_mintues(numbers_mintues);


            Console.WriteLine("Task 9 A: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            compare_two_number(number1, number2);


            Console.WriteLine("Task 9 B: ");
            Sum_Digits();


            Console.WriteLine("Task 10");
            reversed_number();


            Console.WriteLine("Task 11");
            int number_3 = Convert.ToInt32(Console.ReadLine());
            int number_4 = Convert.ToInt32(Console.ReadLine());
            Check_Divisibility(number_3, number_4);


            Console.WriteLine("Task 12");
            int number_5 = Convert.ToInt32(Console.ReadLine());
            int number_6 = Convert.ToInt32(Console.ReadLine());
            int number_7 = Convert.ToInt32(Console.ReadLine());
            Middle_Value(number_7, number_5, number_6); 

        }
    }
}
