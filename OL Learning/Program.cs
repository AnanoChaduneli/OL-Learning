using System.Reflection.Metadata.Ecma335;

class LessonFive
{
    static void Main(string[] args)
    {
        startGame();

    }

    static void startGame()
    {
        welcomingMessage(); 
          
            int randomNumber = getRandomNumber();

            int usersNumber;

        for(int counter=1; counter <= 3; counter++)
        {
            usersNumber = enterNumber();
            if(checkGame(usersNumber,randomNumber,counter))
            {
                return;
            }
            Console.WriteLine("You Have Lost!");
            
        }
        newGame();
    }

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

    static bool checkGame(int userNumber, int randomNumber, int counter)
    {
         if (randomNumber == userNumber)
    {
            Console.WriteLine("You have won!");
            newGame();
            return true;
         }
            else if (randomNumber > userNumber && counter != 3)
         {
                Console.WriteLine("Your number is lower than random number.");
         }
            else if (randomNumber < userNumber && counter != 3)
        {
             Console.WriteLine("Your number is higher than random number");
        }
         return false;
    }

    static void newGame()
    {
        Console.WriteLine();
        string playAgain = "yes";
        Console.WriteLine("Play again (yes / no)?");
        string enteredAnswer = Console.ReadLine();

        if (enteredAnswer == playAgain)
        {
                startGame();
                return;
        }
        else
        {
                 Console.WriteLine("Thanks for game");
        }

    }

}
