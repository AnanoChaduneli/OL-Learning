using System;

/*Lesson 4 Homework 1
 * 1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. 
 * გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
 */
class MyMain
{      
    static void Main(string[] args) // Entry Point
    {
        Console.WriteLine("\nLesson 4 Homework 1\n");
        Console.Write("Sum -  ");
        getParams(5, 10); // პარამეტრის გადაცემა; მეთოდის გამოძახება
       
    }

    static void getParams(int x, int y) //პარამეტრების მიღება
    {
        Console.WriteLine(x + y);
    }

}

 