class LoopHomework
{
    static void Main(string[] args)
    {
        startGame();
    }

    static void startGame()
    {
        welcomingMessage();

        int randomNumber = getRandomNumber();
        int userNumber;

        for (int counter = 1; counter <= 3; counter++)
        {
            userNumber = enterNumber();
            if (checkGame(userNumber, randomNumber, counter))
            {
                return;
            }
        }
        Console.WriteLine("You Haven't guessed the hidden number. You Lost!");
        repeteGame();
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
        Console.Write("Please enter a number: ");

        return Int32.Parse(Console.ReadLine());
    }

    static bool checkGame(int userNumber, int randomNumber, int counter)
    {
        if (randomNumber == userNumber)
        {
            Console.WriteLine("You have WON!");
            return true;
        }
        else if (randomNumber > userNumber && counter < 3)
        {
            Console.WriteLine("Your number is LOWER than random number.");
        }
        else if (randomNumber < userNumber && counter < 3)
        {
            Console.WriteLine("Your number is HIGHER than random number.");
        }
        return false;
    }
    static void repeteGame()
    {
        string repeteAnswer;

        Console.WriteLine("Do You Want To Repete The Game? (Y/N)");
        repeteAnswer = Console.ReadLine();

        if (repeteAnswer == "Y")
        {
            startGame();
        }
        return;
    }

}