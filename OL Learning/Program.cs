using System;

class MyMain
{
    static void Main(string[] args) // Entry Point
    {
        //Lesson 3 Homework 1 
        Console.WriteLine();
        Console.WriteLine("Lesson 3 Homework 1");
        Console.WriteLine();
        int X = 4;
        int y = 9;
        int z = 15;
        int sum = X + (z * y);
        Console.WriteLine("Total Result - " + sum);

        //Lesson 3 Homework 2
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Lesson 3 Homework 2");
        Console.WriteLine();
        Console.Write("Please, enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please, enter your surname: ");
        string surname = Console.ReadLine();
        Console.Write("Please, enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        Console.Write("Please, enter your height(CM): ");
        float height = float.Parse(Console.ReadLine());
        Console.Write("Please, enter your weight(KG): ");
        float weight = float.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Your Name & Surname: " + name+" "+surname);
        Console.WriteLine("Your Age: " + age);
        Console.WriteLine("Your Height: " + height);
        Console.WriteLine("Your Weight: " + weight);



        // Lesson 3 Homework 3
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Lesson 3 Homework 3");
        Console.WriteLine();
        float BMI = weight / ((height/100) * (height/100));
        Console.WriteLine("Your Body Mass Index - " + BMI);

        //Lesson 3 Homework 4
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Lesson 3 Homework 4");
        Console.WriteLine();
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 1 | 2 | 3 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 4 | 5 | 6 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 7 | 8 | 9 ");
        Console.WriteLine("   |   |   ");

    }


}

 