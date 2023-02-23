using System;

class MyMain
{      
    /*Lesson 4 Homework 1
         * 1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. 
         * გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
         */
    static void Main(string[] args) // Entry Point
    {
        getParams(5, 10, "Sum is - ");
        
    }

    static void getParams(int x, int y, string name)
    {
        Console.WriteLine("\nLesson 4 Homework 1\n");
        Console.WriteLine(name +( x + y));
    }

}

 