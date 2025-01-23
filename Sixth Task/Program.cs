using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sixth_Task
{


    class Calculator 
    {
        public void Two_integers(int x, int y)
        {
            Console.WriteLine($" int {x} + int {y} = int {x + y}");
        }
        public void Two_integers(int x, int y, int z)
        {
            Console.WriteLine($" int {x} + int {y} + int {z} = int {x + y}");

        }
        public void Two_integers(double x, double y, double z)
        {
            Console.WriteLine($" double {x} + double {y} + double {z} = double {x + y + z}");

        }
    }


    


     class Shape 
    {
        public virtual void draw() 
        { 
            Console.WriteLine();
        }
      

    }
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine($"Drawing a Circle");

        }

    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine($"Drawing a Rectangle.");

        }

    }


  

    abstract class Animal
    {
        public abstract void voice();
    }
     class Dog : Animal
    {
        public override void voice()
        {
            Console.WriteLine("Howww");
        }
    }
     class Cat : Animal
    {
        public override void voice()
        {
            Console.WriteLine("Meowwwww");
        }
    }
 

    public interface Playable
    {
        void play();
    }
    class Guitar : Playable
    {
        public  void play()
        {
            Console.WriteLine("Playing the guitar.");
        }
    }
    class Piano : Playable
    {
        public void play()
        {
            Console.WriteLine("Playing the piano.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            calculator.Two_integers(a,b);


            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());

            calculator.Two_integers(c,d,e);


            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            calculator.Two_integers(f,g,h);

            Circle circle = new Circle();
            circle.draw();
            Rectangle rectangle = new Rectangle();
            rectangle.draw();

            Dog dog = new Dog();
            dog.voice();
            Cat cat = new Cat();    
            cat.voice();

            Guitar guitar = new Guitar();
            guitar.play();
            Piano piano = new Piano();
            piano.play();
        }
    }
}
