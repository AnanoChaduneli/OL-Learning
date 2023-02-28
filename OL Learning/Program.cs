using System.Reflection.Metadata.Ecma335;

class LessonFive
{
    static void Main(string[] args) // შესვლის წერტილის მეთოდი, მხოლოდ ერთი
    {
        int logNumber = 1;
        while (logNumber <= 3) 
        { 
            logNumber++;
            startGame();

        }
        static void startGame()
    {
       
            welcomingMessage();
          
            int randomNumber = getRandomNumber();

            int usersNumber = enterNumber();

            if (randomNumber == usersNumber)
            {
                Console.WriteLine("You have WON!");
            }
            else if (randomNumber > usersNumber)
            {
                Console.WriteLine("Your number is lower than random number.");
            }
            else if (randomNumber < usersNumber)
            {
                Console.WriteLine("Your number is higher than random number.");
            }
        } }

    static void welcomingMessage()
    {
        Console.WriteLine("Let's play a game. I have a hidden number for you.");
        Console.WriteLine("This number is between 0 to 20. Please, guess it.");
        Console.WriteLine("You have three attempts.");
    }

    static int getRandomNumber()
    {

        return new Random().Next(0, 21);
    }

    static int enterNumber()
    {
        Console.Write("Please, enter a number: ");

        return Int32.Parse(Console.ReadLine());
    }
}