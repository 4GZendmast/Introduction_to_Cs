using System;

namespace ConsoleApp1
{
    class Program
    {
        //Create a C# program that prompts the user to enter their name and age, and then outputs a message with their name and age. The message should say something like "Hello, John! You are 25 years old."
        //The program should perform the following tasks:
        //Use a Console.ReadLine() method to get the user's name and age from the console.
        //Use a string interpolation to format the message that includes the user's name and age.
        //Use a Console.WriteLine() method to output the message to the console.

        static void Main(string[] args)
        {
            string name;
            int age;

            //Ask the user for input
            Console.WriteLine("Enter name: ");
            Console.WriteLine("------------");

            //Store the input in a variable 
            name = Console.ReadLine();

            //Ask the user for input
            Console.WriteLine("------------");
            Console.WriteLine("Enter age: ");

            //Simultaneously store the input and use explicit conversion (type casting) to convert string to int
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine($"Hello {name}! You are {age} years old ");
        }
    }
}
