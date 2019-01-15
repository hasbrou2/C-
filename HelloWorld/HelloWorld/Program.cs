using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born?");
            var month_born = Console.ReadLine();

            Console.WriteLine("My name is: {0}", name);
            Console.WriteLine("My Age is: {0}", age); 
            Console.WriteLine("Month of birth: {0}", month_born);
        }
    }
}
