using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables to zero
            int num1 = 0;
            int num2 = 0;
            
            //Title
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            
            //First number
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            //Second number
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            //Option
            Console.WriteLine("Chose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            
            //Switch Statement
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1-num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            
            //Response to close
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}