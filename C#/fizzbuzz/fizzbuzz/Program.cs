using System;

namespace fizzbuzz
{
    class Program
    {
        public static string output = "";
        public static string[] words = { "fizz", "buzz" };
        public static int[] numbers = { 3, 5 };

        public static void FizzBuzz_Worst()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    output = "FizzBuzz";
                }
                else if (((i % 3) == 0) && ((i % 5) != 0))
                {
                    output = "Fizz";
                }
                else if (((i % 3) != 0) && ((i % 5) == 0))
                {
                    output = "Buzz";
                }
                else
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
            Console.WriteLine("Press Enter To Contimue...");
            while(Console.ReadKey().Key != ConsoleKey.Enter)
            {
                //keep command prompt open
            }
        }

        public static void FizzBuzz_Better()
        {
            int x = 3;
            int y = 5;
            
            for (int i = 1; i <= 100; i++)
            {
                output = "";
                if ((i % x) == 0)
                {
                    output += "Fizz";
                }
                if ((i % y) == 0)
                {
                    output += "Buzz";
                }
                if (((i % x) != 0) && ((i % y) != 0))
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
            Console.WriteLine("Press Enter To Contimue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                //keep command prompt open
            }
        }

        public static void FizzBuzz_Best()
        {
            for (int i = 1; i <= 100; i++)
            {
                output = "";
                for (int y = 0; y < numbers.Length; y++)
                {
                    if (i % numbers[y] == 0)
                    {
                        output += words[y];
                    }
                }
                if (output == "")
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
            Console.WriteLine("Press Enter To Contimue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                //keep command prompt open
            }
        }
        static void Main(string[] args)
        {
            string choice = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter 1 for FizzBuzz with hardcoded values");
                Console.WriteLine("Please enter 2 for FizzBuzz with variables");
                Console.WriteLine("Please enter 3 for FizzBuzz with arrays");
                Console.WriteLine("Please enter anything else to exit the program");

                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        FizzBuzz_Worst();
                        break;
                    case "2":
                        FizzBuzz_Better();
                        break;
                    case "3":
                        FizzBuzz_Best();
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }   
        }
    }
}
