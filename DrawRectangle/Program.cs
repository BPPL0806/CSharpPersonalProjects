namespace DrawRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please type width of rectangle:");
                    width = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("It's not a number!");
                    continue;
                }

                if (width < 1)
                {
                    Console.WriteLine("Invalid width.");
                    continue;
                }

                else
                {
                    break;
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Please type height of rectangle:");
                    height = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("It's not a number!");
                    continue;
                }

                if (height < 1)
                {
                    Console.WriteLine("Invalid height.");
                    continue;
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine();

            for (int range = 0; range != height; range++)
            {
                for (int width_range = 0; width_range != width; width_range++)
                {
                    Console.Write("██");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" \n *If shape isn't displayed correctly, put program into fullscreen.");
        }
    }
}