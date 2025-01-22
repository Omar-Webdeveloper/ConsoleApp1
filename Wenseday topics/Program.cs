using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wenseday_topics
{
    class BaseClass
    {
        // Public property: accessible from anywhere
        public string PublicField { get; private set; } = "Public Field";

        // Private field: accessible only within the BaseClass
        private string privateField = "Private Field";

        // Protected property: accessible within the BaseClass and derived classes
        protected string ProtectedField { get; set; } = "Protected Field";

        // Public method to access the private field
        public string GetPrivateField()
        {
            return privateField;
        }

        // Public method to modify the private field
        public void SetPrivateField(string value)
        {
            privateField = value;
        }

        public void ShowFields()
        {
            Console.WriteLine(PublicField);      // Accessible
            Console.WriteLine(privateField);     // Accessible
            Console.WriteLine(ProtectedField);   // Accessible
        }
    }

    class DerivedClass : BaseClass
    {
        public void ShowProtectedField()
        {
            Console.WriteLine(PublicField);      // Accessible
            //Console.WriteLine(privateField);  // Not accessible (Uncommenting this line will cause a compile error)
            Console.WriteLine(ProtectedField);   // Accessible      
        }
    }

    sealed class SealedClass : DerivedClass
    {
        public string You { get; set; } = Console.ReadLine();

        public void Retrieve()
        {
            Console.WriteLine($" {You} Cannot inherit from me; you can only create an object of me.");
        }
    }

    //class Derived_class_From_sealed : Sealed_class{ } // (Uncommenting this line will cause a compile error)
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();


            //baseObj.PublicField = "lllll"; //(Uncommenting this line will cause a compile error) because of the  set is private and cannot been Accessied outside the class

            // Accessing fields from BaseClass
            Console.WriteLine(baseObj.PublicField);  // Accessible
            // Console.WriteLine(baseObj.GetPrivateField()); // Accessible through public method
            // Console.WriteLine(baseObj.ProtectedField); // Not accessible (Uncommenting this line will cause a compile error)

            // Accessing fields from DerivedClass
            Console.WriteLine(derivedObj.PublicField);  // Accessible
            // Console.WriteLine(derivedObj.GetPrivateField()); // Accessible through public method
            // Console.WriteLine(derivedObj.ProtectedField); // Not accessible (Uncommenting this line will cause a compile error)

            // Calling methods that demonstrate access levels
            baseObj.ShowFields();        // Will show all fields within BaseClass
            derivedObj.ShowProtectedField();  // Will show public and protected fields within DerivedClass

            SealedClass sealedObj = new SealedClass();
            sealedObj.Retrieve();
        }
    }
}
