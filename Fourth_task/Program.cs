﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_task
{
    class Student      // THe class
    {
        // Private field for student name 

        private string student_name;

        // Public property for student name

        public string Student_Name { get; set; }
        // Constant for minimum student age
        public const int Min_Student_age = 18;
        // Private field for student name 

        public int student_age;
        // Constant for maximum student age
        public const int Max_Student_age = 40;
        // Public property for student age with validation in the setter
        public int Student_Age
        {
            get { return student_age; }
            set
            {
                if (value <= Max_Student_age && value >= Min_Student_age) { student_age = value; }
                else { student_age = 0; Console.WriteLine("next year "); }
            }

        }
        // Private field for student ID
        private int student_ID;
        // Public property for student ID
        public int Student_ID { get; set; }
        // Private field for student email
        private string student_email;
        // Public property for student email
        public string Student_Email { get; set; }
        // Constant for school name
        private const string School_name = "Orange Coding Academy";
        // Private field for survey
        private string survey;
        // Public property for survey
        public string Survey
        {
            get { return survey; }

            set { survey = value; }
        }

        //Default constructor the doesn't do any action
        public Student()
        {
            Student_Age = 0;
            Student_Name = "Nothing is here";
            Student_ID = 0;
            Student_Email = "Nothing is here";
            Survey = "Nothing is here";


        }
        //passing parameters to the consructer  for better readabilty and reusablty for the object called from this class
        public Student(string name, int age, int ID, string gmail, string comment)  
        {
            Student_Name = name;   // gave intial value for Student_Name from passing name value to Student_Name
            student_age = age;// gave intial value for student_age from passing age value to student_age
            Student_ID = ID;// gave intial value for Student_ID from passing ID value to Student_ID
            Student_Email = gmail;// gave intial value for Student_Email from passing gmail value to Student_Email
            Survey = comment;// gave intial value for Survey from passing comment value to Survey
        }


        public void Print_info() // method to print all property and feilds in this class
        {
            Console.WriteLine($"\nSchool name : {School_name} \n\nStudent name : {Student_Name} \n\nStudent age : {student_age} \n\nStudent ID : {Student_ID} \n\nStudent email : {Student_Email} \n\nSurvey :{Survey} \n");
        }

        ~Student() // Destructor that displays a message when the object is being destroyed 
        {
            Console.WriteLine("Object under delete");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create and initialize the Third student object using the parameterized constructor
            Student new_student_03 = new Student("Ahmad", 22, 1001, "my_email", "my_comment");
            new_student_03.Print_info();  // Print the information of the Third student

            // Create and initialize the Third student object using the parameterized constructor
            Student new_student_04 = new Student();
            new_student_04.Print_info();  // Print the information of the Third student

            // Create and initialize the first student object using the default constructor
            Student new_student_01 = new Student();
            Console.WriteLine("Enter the student's name:");
            new_student_01.Student_Name = Console.ReadLine();  // Set student name from user input 
            Console.WriteLine("Enter the student's age:");
            new_student_01.Student_Age = Convert.ToInt32(Console.ReadLine());  // Set student age from user input then convert it to int value
            Console.WriteLine("Enter the student's ID:");
            new_student_01.Student_ID = Convert.ToInt32(Console.ReadLine());  // Set student ID from user input then convert it to int value
            Console.WriteLine("Enter the student's email:");
            new_student_01.Student_Email = Console.ReadLine();  // Set student email from user input 
            Console.WriteLine("Enter the survey comment:");
            new_student_01.Survey = Console.ReadLine();  // Set survey comment from user input 
            new_student_01.Print_info();  // Print the information of the first student

            Console.WriteLine("Enter the student's name:");
            string my_name = Console.ReadLine();  // Set student name from user input 
            Console.WriteLine("Enter the student's age:");
            int my_age = Convert.ToInt32(Console.ReadLine());  // Set student age from user input then convert it to int value
            Console.WriteLine("Enter the student's ID:");
            int my_id = Convert.ToInt32(Console.ReadLine());  // Set student ID from user input then convert it to int value
            Console.WriteLine("Enter the student's email:");
            string my_email = Console.ReadLine();  // Set student email from user input 
            Console.WriteLine("Enter the survey comment:");
            string my_comment = Console.ReadLine();  // Set survey comment from user input 

            // Create and initialize the second student object using the parameterized constructor
            Student new_student_02 = new Student(my_name, my_age, my_id, my_email, my_comment);
            new_student_02.Print_info();  // Print the information of the second student            




            string Q1 ="1. What is a class?"; 
            Console.WriteLine($" {Q1}\n\t\tA class is a blueprint for creating objects. It defines properties, methods.");

            string Q2 = "2. What is an object?"; 
            Console.WriteLine($" {Q2}\n\t\tAn object is an instance of a class. It is created from a class and can access its properties and methods.");

            string Q3 = "3. Difference between class and object?"; 
            Console.WriteLine($" {Q3}\n\t\tA class is a template or blueprint, while an object is an instance of that class.\n The class defines the structure and behavior, while the object is the actual entity that exists in memory.");

            string Q4 = "4. Mention the OOP Principles."; 
            Console.WriteLine($" {Q4}\n\t\tThe four fundamental principles of Object-Oriented Programming are Encapsulation, Abstraction, Inheritance, and Polymorphism.");

            string Q5 = "5. What is a property?"; 
            Console.WriteLine($" {Q5}\n\t\tA property is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field.\n Properties can include logic for validation or computation.");

            string Q6 = "6. What is a field?"; 
            Console.WriteLine($" {Q6}\n\t\tA field is a variable that is declared directly in a class or struct. It holds data associated with the object or class.");

            string Q7 = "7. What is a constructor?"; 
            Console.WriteLine($" {Q7}\n\t\tA constructor is a special method in a class that is called when an object of the class is created. It is used to initialize the object.");

            string Q8 = "8. What is encapsulation?"; 
            Console.WriteLine($" {Q8}\n\t\tEncapsulation is the concept of bundling data (fields) and methods (functions) that operate on the data into a single unit (a class). It restricts direct access to some of the object's components, promoting data integrity and security.");
        }
    }
}
