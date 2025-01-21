using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Hotel_Reservation_System
    {
        public int Room_Number;
        public  void Room_Type()
        {
            Console.WriteLine(" Enter 1 = Single \n Enter 2 = Double \n Enter 3 = Suite");
            string x = Console.ReadLine();

            if (x == "1")
            {
                Console.WriteLine("Room type : Single");
            }
            else if (x == "2")
            {
                Console.WriteLine("Room type : Double");

            }
            else if (x == "3")
            {
                Console.WriteLine("Room type : Suite");

            }
        }
        public double Price_Per_Night;
        public  void IsBooked()
        {
            Console.WriteLine(" Enter 1 = Avilable \n Enter 2 = press any key to countinue ");
            string x = Console.ReadLine();

            if (x == "1")
            {
                Console.WriteLine(" Is it Booked ? \n No, it is Avilable");
            }
            else
            {
                Console.WriteLine(" Is it Booked ? \n Yes, it is Booked");

            }
        }
        public const string HotelName = "Grand Stay Hotel";


    }

   
    internal class Program
    {
        static void Question_1()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0) { Console.WriteLine("EVEN"); }
            else if (x % 2 == 1) { Console.WriteLine("ODD"); }
            else { Console.WriteLine("Something went wrong"); }
        }
        static void Question_2()
        {
            int number_1 = Convert.ToInt32(Console.ReadLine());
            int number_2 = Convert.ToInt32(Console.ReadLine());
            int number_3 = Convert.ToInt32(Console.ReadLine());
            int number_4 = Convert.ToInt32(Console.ReadLine());
            int number_5 = Convert.ToInt32(Console.ReadLine());

            int[] val = new int[5];
            val[0] = number_1;
            val[1] = number_2;
            val[2] = number_3;
            val[3] = number_4;
            val[4] = number_5;

            Array.Sort(val);

            int nd_number = val[1];
            Console.WriteLine(nd_number);
        }
        static void Question_3()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Factorial of {number}  is: {factorial}");

        }
        static void Question_4()
        {
            int number_1 = Convert.ToInt32(Console.ReadLine());
            int number_2 = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            for (int i = number_1; i <= number_2; i++)
            {
                for (int j = 2; j <= number_2; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine("\t" + i);
                }
                isPrime = true;
            }
        }
        static void Question_5(int n)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = numbers[0];
            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }

            // Output the largest number
            Console.WriteLine($"The largest number is: {largest}");



        }

        static void Question_6()
        {

            int i, j, rows, k = 1;

            Console.Write("\n\n");
            Console.Write("Display the pattern like right angle triangle with number increased by 1:\n");
            Console.Write("---------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }

        }
        //static void Question_7() { }
        //static void Question_8() { }
        //static void Question_9() { }



        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: The number is Even or Odd?");
            Question_1();

            Console.WriteLine("Question 2: The2nd Smallest number ? \n Enter 5 number only");

            Question_2();

            Console.WriteLine("Question 3: calculates the factorial of a given number ?");
            Question_3();

            Console.WriteLine("Question 4: two integers as input and prints all the prime numbers between them using nested loops?");
            Question_4();

            Console.WriteLine("Question 5: that initializes an integer array and finds the largest number in it using a foreach loop? \n enter the size of the array \n then enter the nmbers based on the size");
            int x = Convert.ToInt32(Console.ReadLine());
            Question_5(x);

            Console.WriteLine("Question 6: Write a program that prints the following number pattern using nested loops?");
            Question_6();

            //Console.WriteLine("Question 1:The number is Even or Odd?");
            //Question_7();

            //Console.WriteLine("Question 1:The number is Even or Odd?");
            //Question_8();

            //Console.WriteLine("Question 1:The number is Even or Odd?");
            //Question_9();

            Console.WriteLine("Question 10: Create a Hotel Reservation System where the program manages room bookings for a hotel?");

            Hotel_Reservation_System room = new Hotel_Reservation_System();
            room.Room_Number = 101;
            room.Price_Per_Night = 150.00;
            room.Room_Type();
            room.IsBooked();
            Console.WriteLine($"room number: {room.Room_Number}");
            Console.WriteLine($"Romm Price per day : {room.Price_Per_Night}");

            Console.WriteLine();
            Console.WriteLine();

            Hotel_Reservation_System room1 = new Hotel_Reservation_System();
            room1.Room_Number = 133;
            room1.Price_Per_Night = 44555;
            room1.Room_Type();
            room1.IsBooked();
            Console.WriteLine($"room number: {room1.Room_Number}");
            Console.WriteLine($"Romm Price per day : {room1.Price_Per_Night}");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
