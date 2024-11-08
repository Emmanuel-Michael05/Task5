using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet("Alice");
        }
       
        string name;

        public static void Greet(string name) 
        {
          
            Console.WriteLine($"Hello {name}!");
        }

        
    }
}