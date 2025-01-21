using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving
{

    internal class Program
    {
        //static void CountVowels(string x)
        //{
        //    int c = x.Length;
           
        //    int q = 0;

        //    char l1 = 'a', l2 = 'e', l3 = 'i', l4 = 'o', l5 = 'u';

        //    for (int i =0; i < c; i++)
        //    {
        //       if (x[i] == l1){q++;}
        //       if (x[i] == l2) { q++; }
        //       if (x[i] == l3) { q++; }
        //       if(x[i] == l4) { q++; }
        //       if (x[i] == l5) { q++; }
        //    }
        //    Console.WriteLine(q);
        //}


        //static void count()
        //{
        //    int total = 0;

        //    Console.WriteLine("Enter a Sentence");
        //    string sentence = Console.ReadLine().ToLower();

        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        if (sentence[i] = "a" || sentence[i] = "e" || sentence[i] = "i" || sentence[i] = "o" || sentence[i] = "u")
        //        {
        //            total++;
        //        }
        //    }
        //    Console.WriteLine("Your total number of vowels is: {0}", total);

        //}


        static void counts() 
            {
                Console.WriteLine("Enter a string: ");
                string x = Console.ReadLine();
                int count = 0;
                foreach (char c in x)
                {
                if ("aeiouAEIOU".Contains(c))
                {
                    count++;
                }
                }
            Console.WriteLine("Number of vowels: " + count);
        }



        public static void jana()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Not Prime");

                    break;
                }

                else
                {

                    bool x1 = true;
                    a++;
                    if (a > 3)
                    {
                        Console.WriteLine("Not Prime");
                    }
                    
                        
                     

                }
            }
            if (a == 1)
            {

                Console.WriteLine("Prime");
            }
        }
        static void Main(string[] args)
            {
            jana(); 
            //counts();

            //string name = "omar abo jolban";
            //foreach (char c in name) {Console.WriteLine(c);}


            //string ttext = Console.ReadLine();
            //CountVowels(ttext);

            //count();
        }
    }
    }

