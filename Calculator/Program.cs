using System;

namespace Calculator
{
    class Program
    {
        static int Main(string[] args)
        {
            // Check for the right number of arguments
            if (args.Length < 3)
            {
                Console.WriteLine("Not enough arguments!");
                return 0;
            }
            if (args.Length > 3)
            {
                Console.WriteLine("Too many arguments!");
                return 0;
            }

            // Try to parse arguments 1 and 3 as floats
            if (!float.TryParse(args[0], out float x))
            {
                Console.WriteLine($"{args[0]} is not a number!");
                return 0;
            }
            if (!float.TryParse(args[2], out float y))
            {
                Console.WriteLine($"{args[2]} is not a number!");
                return 0;
            }
            
            // Try to perform the requested operation
            switch (args[1])
            {
                case "+":
                    Console.WriteLine(x + y);
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    break;
                case "*":
                    Console.WriteLine(x * y);
                    break;
                case "/":
                    Console.WriteLine(x / y);
                    break;
                default:
                    Console.WriteLine($"Unrecognized operation: {args[1]}");
                    break;
            }

            return 0;
        }
    }
}
