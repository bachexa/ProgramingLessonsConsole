using System;
using System.Collections.Generic;

namespace ProgramingLessons
{
    internal class Program
    {
        // Entry point
        static void Main(string[] args)
        {
            // --- your code here ---
            int age = 32;
            double price = 19.99;
            decimal salary = 75000.50m;
            bool isActive = true;
            char grade = 'A';
            string name = "Maya";

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
            Console.WriteLine($"Price: {price}, Salary: {salary}, Active: {isActive}");

            int[] scores = new[] { 90, 85, 92 };
            var names = new List<string> { "Ana", "Ben" };
            Console.WriteLine($"First score: {scores[0]}, First name: {names[0]}");

            // keep window open (optional)
            // Console.ReadLine();


            Console.Write("Enter your name: ");
            string? name2 = Console.ReadLine();

            Console.WriteLine(name2);

            Console.ReadKey();
        }
    }
}

