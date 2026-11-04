using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramingLessons
{
    internal class Program
    {
        // Entry point
        static void Main(string[] args)
        {

            Console.Write("reikvanet ricxvi1: ");
            string x = Console.ReadLine();

            double ricxvi1 = Convert.ToDouble(x);


            Console.Write("reikvanet ricxvi2: ");

            string y = Console.ReadLine();

            int ricxvi2 = Convert.ToInt32(y);
           
            
            //-----------------
            double jami = ricxvi1 + ricxvi2;

            double sxvaoba = ricxvi1 - ricxvi2;

            double namravli = ricxvi2 * ricxvi1;


            double ganakofi = (double)ricxvi1 / (double)ricxvi2;


            Console.WriteLine($" {ricxvi1} + {ricxvi2} =" + jami);

            Console.WriteLine($" {ricxvi1} - {ricxvi2} =" + sxvaoba);

            Console.WriteLine($" {ricxvi1} * {ricxvi2} =" + namravli);

            Console.WriteLine($" {ricxvi1} / {ricxvi2} =" + Math.Round(ganakofi,2));

            Console.ReadKey();
        }
    }
}

