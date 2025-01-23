using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fifth_Task
{
    class Vehicle
    {
        private string brand;
        public string Brand { get; set; }

        private int model;

        public int Model { get; set; }
        public void Laws()
        {
            Console.WriteLine($"logo :{Brand} \nYear :{Model}");
        }


    }
    sealed class Car : Vehicle
    {
        private int number_of_doors;
        public int Number_of_doors 
        { 
            get { return number_of_doors; }
            set { if (value > 4) { Console.WriteLine($" {value} is not  accept it "); }
                else { number_of_doors = value; } 
            }
                 
        }

        public void policy()
        {
            Console.WriteLine($" all the {Brand} cars must have {number_of_doors} doors and must be new to this year {Model}");
        }

    }

    //class options_for_car : Car
    //{
    //    public options_for_car()
    //    {
    //        Console.WriteLine("Full touch screen");
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            string Q1 = "1. What is constructor?";
            Console.WriteLine($" {Q1}\n\t\tA constructor is a special method that gets called automatically when you create an object of a class.it is a way to set up the initial state of the object. constructors have the same name as the class and don't have a return type.");

            string Q2 = "2. What are the basic concepts of OOPs?";
            Console.WriteLine($" {Q2}\n\t\tThe four fundamental principles of Object-Oriented Programming are Encapsulation, Abstraction, Inheritance, and Polymorphism.");

            string Q3 = "3. What is the Encapsulation?";
            Console.WriteLine($" {Q3}\n\t\tEncapsulation is the concept of bundling data (fields) and methods (functions) that operate on the data into a single unit (a class). It restricts direct access to some of the object's components, promoting data integrity and security.");

            string Q4 = "4. What is the sealed class?";
            Console.WriteLine($" {Q4}\n\t\tA sealed class is a class that cannot be inherited. This means you can't create a subclass from it. It's useful when you want to prevent further modification of a class.");

            string Q5 = "5. What is the Inheritance concept?";
            Console.WriteLine($" {Q5}\n\t\tInheritance allows one class (child class) to use the properties and methods of another class (parent class). It's a way to reuse code and create a parent-child relationship between classes.");


            Vehicle factory = new Vehicle();
            Console.WriteLine("Enter the brand of the vehicle:");
            factory.Brand = Console.ReadLine();

            Console.WriteLine("Enter the model year of the vehicle:");
            factory.Model = Convert.ToInt32(Console.ReadLine());
            factory.Laws();

            Car car = new Car();
            Console.WriteLine("Enter the number of doors for the car:");
            car.Number_of_doors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the brand of the car:");
            car.Brand = Console.ReadLine();

            Console.WriteLine("Enter the model year of the car:");
            car.Model = Convert.ToInt32(Console.ReadLine());
            car.policy();

            





    }
}
}
