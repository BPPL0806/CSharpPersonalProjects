namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int random_num = random.Next(1, 50); //Generate number 1-50
            int tries = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Guess number from 1 to 50");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    tries++;

                    if (answer == random_num && tries == 1)
                    {
                        Console.WriteLine("Correct answer! It's " + random_num);
                        Console.WriteLine("You guessed it at 1st try!");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        break;
                    }

                    else if (answer < random_num)
                    {
                        Console.WriteLine("Generated number is bigger than " + answer + ".");
                        continue;
                    }

                    else if (answer > random_num)
                    {
                        Console.WriteLine("Generated number is smaller than " + answer + ".");
                        continue;
                    }

                    if (answer == random_num)
                    {
                        Console.WriteLine("Correct answer! It's " + random_num + ".");
                        Console.WriteLine("You guessed the number at " + tries + " tries.");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                    }   break;
                }

                catch (Exception) //Error handling
                {
                    Console.WriteLine("It's not a number!");
                    continue;
                }
            }
        }    
    }
}