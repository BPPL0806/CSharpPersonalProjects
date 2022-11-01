using System.Runtime.InteropServices;

namespace LogicGatesSimulator
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please enter input A (0 / 1): ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter input B (0 / 1): ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if((a < 0 || a > 1) || (b < 0 || b > 1))
                    {
                        throw new FormatException();
                    }

                    int output;
                    Console.Clear();

                    Console.WriteLine("A = " + a + " | B = " + b + "\n");

                    if(a == 1 && b == 1) //AND
                    {
                        output = 1;
                    }

                    else
                    {
                        output = 0;
                    }

                    Console.WriteLine("AND - " + output);

                    if(a == 1 || b == 1) //OR 
                    {
                        output = 1;
                    }

                    else
                    {
                        output = 0;
                    }

                    Console.WriteLine("OR - " + output);

                    if(a == 1 && b == 1) //NAND 
                    {
                        output = 0;
                    }

                    else
                    {
                        output = 1;
                    }

                    Console.WriteLine("NAND - " + output);

                    if (a == 0 && b == 0) //NOR
                    {
                        output = 1;
                    }

                    else
                    {
                        output = 0;
                    }

                    Console.WriteLine("NOR - " + output);

                    if((a == 1 && b == 1) || (a == 0 && b == 0)) //XOR
                    {
                        output = 0;
                    }

                    else
                    {
                        output = 1;
                    }

                    Console.WriteLine("XOR - " + output);

                    if ((a == 1 && b == 1) || (a == 0 && b == 0)) //XNOR
                    {
                        output = 1;
                    }

                    else
                    {
                        output = 0;
                    }

                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadKey();
                    break;

                }

                catch (FormatException e)
                {

                    Console.WriteLine("\nPlease re-enter valid inputs!\n");
                    continue;

                }
            }
        }
    }
}