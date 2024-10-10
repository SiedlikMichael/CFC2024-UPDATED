using System;

public class Program
{
    public static void Main()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, " + name + "! Do you want to do the COIN FLIP CHALLENGE? (YES / NO)");
        string response = Console.ReadLine().ToLower();

        if (response == "yes")
        {
            int score = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name + ", Heads? or Tails?");
                string choice = Console.ReadLine().ToLower();

                Random random = new Random();
                int randomNumber = random.Next(2);
                string result = randomNumber == 0 ? "heads" : "tails";

                if (choice == result)
                {
                    score++;
                    Console.WriteLine("Congratulations " + score + ".");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }

            // Display the total score
            Console.WriteLine(name + ", your total correct guesses: " + score);
        }
        else
        {
            Console.WriteLine("Coward!");
        }
    }
}
