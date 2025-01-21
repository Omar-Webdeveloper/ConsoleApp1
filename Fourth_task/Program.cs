using System;
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
                else { Console.WriteLine("next year "); }
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

        }
        //passing parameters to the consructer  for better readabilty and reusablty for the object called from this class
        public Student(string name, int age, int ID, string gmail, string comment)  
        {
            Student_Name = name;
            student_age = age;
            Student_ID = ID;
            Student_Email = gmail;
            Survey = comment;
        }


        public void Print_info() // method to print all property and feilds in this class
        {
            Console.WriteLine($"School name : {School_name} \nStudent name : {Student_Name} \nStudent age : {student_age} \nStudent ID : {Student_ID} \nStudent email : {Student_Email} \nSurvey :{Survey} ");
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
            // Create and initialize the first student object using the default constructor
            Student new_student_01 = new Student();
            new_student_01.Student_Name = "sleman";  // Set student name
            new_student_01.Student_Age = 33;         // Set student age
            new_student_01.Student_ID = 2019;        // Set student ID
            new_student_01.Student_Email = "sleman@gmail.com";  // Set student email
            new_student_01.Survey = "everything to our like";  // Set survey comment
            new_student_01.Print_info();  // Print the information of the first student

            // Create and initialize the second student object using the parameterized constructor
            Student new_student_02 = new Student("omar abo jolban", 22, 2020, "omarabojolban9@gmail.com", "everything goes well");
            new_student_02.Print_info();  // Print the information of the second student




            Console.WriteLine("1. What is a class?"); 
            Console.WriteLine("A class is a blueprint for creating objects. It defines properties, methods, and events."); 

            Console.WriteLine("\n2. What is an object?"); 
            Console.WriteLine("An object is an instance of a class. It is created from a class and can access its properties and methods."); 
            
            Console.WriteLine("\n3. Difference between class and object?"); 
            Console.WriteLine("A class is a template or blueprint, while an object is an instance of that class. The class defines the structure and behavior, while the object is the actual entity that exists in memory."); 
            
            Console.WriteLine("\n4. Mention the OOP Principles."); 
            Console.WriteLine("The four fundamental principles of Object-Oriented Programming are Encapsulation, Abstraction, Inheritance, and Polymorphism."); 
            
            Console.WriteLine("\n5. What is a property?"); 
            Console.WriteLine("A property is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can include logic for validation or computation."); 
            
            Console.WriteLine("\n6. What is a field?"); 
            Console.WriteLine("A field is a variable that is declared directly in a class or struct. It holds data associated with the object or class."); 
            
            Console.WriteLine("\n7. What is a constructor?"); 
            Console.WriteLine("A constructor is a special method in a class that is called when an object of the class is created. It is used to initialize the object."); 
            
            Console.WriteLine("\n8. What is encapsulation?"); 
            Console.WriteLine("Encapsulation is the concept of bundling data (fields) and methods (functions) that operate on the data into a single unit (a class). It restricts direct access to some of the object's components, promoting data integrity and security.");
        }
    }
}
