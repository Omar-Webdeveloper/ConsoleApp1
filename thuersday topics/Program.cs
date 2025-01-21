using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuersday_topics
{

    public class DemoEncap
    {
        // private variables declared
        // can accessed by
        // public methods of class
        private String studentName;
        private int studentAge;

        public String Name
        {
            get { return studentName; }

            set { studentName = value; }
        }

        // using accessors to get and
        // set the value of studentAge
        public int Age
        {
            get { return studentAge; }

            set { studentAge = value; }
        }
    }

    public class Hotel_Reservation_System_after_editing
    {
        public Hotel_Reservation_System_after_editing() 
        {
            Console.WriteLine("Hello my hotel");
        }
        public Hotel_Reservation_System_after_editing(int number) 
        {
            int Room_Number = number;
        }
        public int Room_Number;
        public void Room_Type()
        {
            Console.WriteLine(" Enter 1 = Single \n Enter 2 = Double \n Enter 3 = Suite");
            string x = Console.ReadLine();

            if (x == "1")
            {
                Console.WriteLine("Single");
            }
            else if (x == "2")
            {
                Console.WriteLine("Double");

            }
            else if (x == "3")
            {
                Console.WriteLine("Suite");

            }
        }
        private double price_per_night;

        public double Price_Per_Night
        {
            get { return price_per_night; }
            set
            {
                if (value >= 0) 
                {
                    price_per_night = value;
                }
                else
                {
                    Console.WriteLine("Price per night must be non-negative.");
                }
            }
        }

        public void IsBooked()
        {
            Console.WriteLine(" Enter 1 = Avilable \n Enter 2 = press any key to countinue ");
            string x = Console.ReadLine();

            if (x == "1")
            {
                Console.WriteLine("Avilable");
            }
            else
            {
                Console.WriteLine("Booked");

            }
        }
        public const string HotelName = "Grand Stay Hotel";

        ~Hotel_Reservation_System_after_editing(){
            Console.WriteLine("Print the Deleted");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoEncap obj = new DemoEncap();

            //// calls set accessor of the property Name,
            //// and pass value
            //obj.Name = "Ankita";

            //// calls set accessor of the property Age,
            //// and pass "21" as value of the
            //// standard field 'value'
            //obj.Age = 21;

            //// Displaying values
            //Console.WriteLine(" Name : " + obj.Name);
            //Console.WriteLine(" Age : " + obj.Age);



            //Hotel_Reservation_System_after_editing room = new Hotel_Reservation_System_after_editing();
            //room.Room_Number = 101;
            //room.Price_Per_Night = 150.00;
            //room.Room_Type();
            //room.IsBooked();
            //Console.WriteLine(room.Room_Number);
            //Console.WriteLine(room.Price_Per_Night);

            //Console.WriteLine();
            //Console.WriteLine();

            //Hotel_Reservation_System_after_editing room1 = new Hotel_Reservation_System_after_editing();
            //room1.Room_Number = 133;
            //room1.Price_Per_Night = 44555;
            //room1.Room_Type();
            //room1.IsBooked();
            //Console.WriteLine(room1.Room_Number);
            //Console.WriteLine(room1.Price_Per_Night);
            //Console.WriteLine();
            //Console.WriteLine();


            Hotel_Reservation_System_after_editing new_one = new Hotel_Reservation_System_after_editing(17777);
            new_one.Price_Per_Night = 3333333;

        }
    }
}
