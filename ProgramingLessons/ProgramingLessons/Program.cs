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

            //დავალება 1

            /*შექმენი ცვლადები და გამოიტანე ეკრანზე შემდეგი ინფორმაცია
             1 სახელი გვარი
             2 დაბადების ადგილი
             3 დაბადების თარიღი
             4 მშობლების სახლი გვარი
             სკოლის საშვალო ქულა მაგ 9,5
             გხავს თუ არა დედმამიშვილი კი/არა
             
             მაშინ მისი სახელი გვარი დაბადბეის თარიღი ასაკი


             
            რა ფორმით უნდა გამომიტანო დავალება 

            saxeli: Elene
            gvari: Tsagareli
            Asaki: 12
            Dabadebis adgili: Tbilisi
            Dabadebis Tarigi :2013
            Dedamishvili: true

             */








            //1
            //int x = 1598;
            //int y = 15478;

            //int z = x + y;

            //string shedegi = $"{x} + {y} = {z}";

            //Console.WriteLine(shedegi);



            //double price = 19.99;
            //decimal salary = 75000.50m;
            //bool isActive = true;
            //char grade = 'A';
            //string name = "Elene elene bacho elene bacho dani ";


            //Console.WriteLine(age);
            // Console.ReadKey();








            //მონაცემები შეყვანა კონსოლიდან გადაკონვერტირება სხვადასხვა ტიპებში და მათემატიკური ოპერაციები
            string label = "Sheikvanet pirveli ricxvi:";

            Console.WriteLine(label);

            string monacemi1 = Console.ReadLine();

            int intMonacemi1 = Convert.ToInt32(monacemi1);

            string label2 = "sheikvanet meore ricxvi";

            Console.WriteLine(label2);

            string monacemi2 = Console.ReadLine();

            int intMonacemi2 =  Convert.ToInt32(monacemi2);

            string jami = monacemi1 + monacemi2;

            int jamiInt = intMonacemi1 + intMonacemi2;

            int sxvaoba = intMonacemi1 - intMonacemi2;

            int gamravleba = intMonacemi1 * intMonacemi2;

            int ganakopiInt = intMonacemi1 / intMonacemi2;

         

            

            Console.WriteLine(monacemi1 + " + " + monacemi2 + " = " + jami);

            Console.WriteLine(intMonacemi1 + " + " + intMonacemi2 + " = " + jamiInt);

            Console.WriteLine(intMonacemi1 + " - " + intMonacemi2 + " = " + sxvaoba);

            Console.WriteLine(intMonacemi1 + " * " + intMonacemi2 + " = " + gamravleba);

            Console.WriteLine(intMonacemi1 + " / " + intMonacemi2 + " = " + ganakopiInt);



       /*გავასწოროთ შემდეგი შეცდომები 
        * 1.როცა წილადი რიცხვი შემყავს შედომა რომ არ გამოიტანოს 
        * 2 როცა გაყოფა ხდება მომცეს სრული წილადი რიცხვი არსებობის შემთხვევაში 
        
        
        */












            //მათემატიკური ოპერაციები 

            //პირობითი ოპერატორები if else, switch case

            //ლოგიკური ოპერატორები



            //ციკლები for, while, do wtile, foreach => ამას განვიხილავთ მოგვიანებით 

            //მასივები 

            //ფუქნციები

            //კლასები
        }
    }
}

