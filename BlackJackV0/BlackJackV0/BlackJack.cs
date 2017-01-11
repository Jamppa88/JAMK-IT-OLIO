using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
    static void Main()
    {
            // Initializing rng and local variables
            Random rng = new Random();
            int myNumber;
            int theirNumber;
            string input;
            System.Console.WriteLine("*** BlackJack! ***");
            while (true)
            {
                System.Console.Write("Can you beat my number? If you want to exit, type X or exit.\nEnter any number between 1-21: ");
                // taking input first to a string
                input = Console.ReadLine();
                // exit commands
                if (input == "X" || input == "exit" || input == "x")
                {
                    Console.WriteLine("Thanks for playing! :)");
                    break;
                }
                // trying to see if input is valid
                else if (int.TryParse(input,out theirNumber) == false)
                {
                    Console.WriteLine("Type a number or X to exit! Try again.");
                }
                // Actual game
                else
                {
                    // converting
                    theirNumber = System.Convert.ToInt32(input);
                    myNumber = rng.Next(10, 21);
                    //comparing that given number is valid

                    if (theirNumber < 1 || theirNumber > 21)
                    {
                        Console.WriteLine("The given number is out of limits, try again.");
                    }
                    else
                    {
                        Console.WriteLine("My number is " + myNumber);
                        //comparing
                        if (theirNumber >= myNumber && theirNumber <= 21)
                        {
                            System.Console.WriteLine("You win.");
                        }
                        else
                        {
                            System.Console.WriteLine("You lose.");
                        }
                    }
                }
            } // while
        Console.ReadLine();
    }
  }
}