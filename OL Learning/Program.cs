using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

/* Lesson 4 Homework 1
 *    შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. 
 * გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
 * Lesson 4 Homework 2
 *    შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი). 
 * მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე დიდი და ყველაზე პატარა. 
 * მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.
 * Lesson 4 Homework 3
 *    შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება. 
 * ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით ნახოს თუ რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება. 
 * თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება. 
 * ხილი: apple, watermelon, melon, cherry, straweberry
 * */

class MyMain
{      
    static void Main(string[] args) // Entry Point
    {   //Lesson 4 Homework 1
        Console.WriteLine("\nLesson 4 Homework 1\n");
        Console.Write("Sum -  ");
        getParams(5, 10); // პარამეტრის გადაცემა; მეთოდის გამოძახება
        //Lesson 4 Homework 2
        getMinMax(); // მეთოდის გამოძახება
        

    }

    static void getParams(int x, int y) //Homework 1 - პარამეტრების მიღება
    {
        Console.WriteLine(x + y);
    }

    static void getMinMax()
    {
        //Lesson 4 Homework 2
        Console.WriteLine("\n\nLesson 4 Homework 2\n");
        Console.Write("Number N1 - ");
        decimal number1 = decimal.Parse(Console.ReadLine());
        Console.Write("Number N2 - ");
        decimal number2 = decimal.Parse(Console.ReadLine());
        Console.Write("Number N3 - ");
        decimal number3 = decimal.Parse(Console.ReadLine());
        Console.Write("Number N4 - ");
        decimal number4 = decimal.Parse(Console.ReadLine());
        Console.WriteLine();

        //Max Value
        if (number1 > number2 && number1 > number3 && number1 > number4)
        {
            Console.WriteLine("Max value is - " + number1);
              } else if (number2 > number3 && number2 > number4)
          {
            Console.WriteLine("Max value is - " + number2);
              } else if (number3 > number4)
          {
            Console.WriteLine("Max value is - " + number3);
              } else
          {
            Console.WriteLine("Max value is - " + number4);
        }
       
        //Min Value
        if (number1 < number2 && number1 < number3 && number1 < number4)
        {
             Console.WriteLine("Min value is - " + number1);
             } else if (number2 < number3 && number2 < number4)
          {
            Console.WriteLine("Min value is - " + number2);
             } else if (number3 < number4)
          {
            Console.WriteLine("Min value is - " + number3);
             } else
          {
            Console.WriteLine("Max value is - " + number4);
        }
    }
}

 