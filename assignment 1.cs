using System;
using System.IO;

namespace Assignment_1
{
    internal class Program
    {
        void A1()
        {
            Console.Write("Give an input in order to typecast: ");
            string input = Console.ReadLine();

            // Converting into integer
            try
            {
                int intValue = Convert.ToInt32(input);
                Console.WriteLine($"Integer value: {intValue}");
            }
            catch
            {
                Console.WriteLine("Input is not a valid integer.");
            }

            // Checking for boolean using Convert.ToBoolean
            try
            {
                bool boolValue = Convert.ToBoolean(input);
                Console.WriteLine($"Boolean value: {boolValue}");
            }
            catch
            {
                Console.WriteLine("Input is not a valid boolean.");
            }

            // Converting into double
            try
            {
                double doubleValue = Convert.ToDouble(input);
                Console.WriteLine($"Double value: {doubleValue}");
            }
            catch
            {
                Console.WriteLine("Input is not a valid double.");
            }

            // Converting into decimal
            try
            {
                decimal decimalValue = Convert.ToDecimal(input);
                Console.WriteLine($"Decimal value: {decimalValue}");
            }
            catch
            {
                Console.WriteLine("Input is not a valid decimal.");
            }

            // Converting into DateTime
            try
            {
                DateTime dateTimeValue = Convert.ToDateTime(input);
                Console.WriteLine($"DateTime value: {dateTimeValue}");
            }
            catch
            {
                Console.WriteLine("Input is not a valid DateTime.");
            }

            // Taking two numbers for arithmetic operations
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");
            Console.WriteLine($"Quotient: {(num2 != 0 ? (num1 / num2).ToString() : "Cannot divide by zero")}");
        }

        void A2()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Uppercase: {input.ToUpper()}");
            Console.WriteLine($"Lowercase: {input.ToLower()}");
            Console.WriteLine($"Trimmed: '{input.Trim()}'");
            Console.WriteLine($"Replaced 'l' with '*': {input.Replace('l', '*')}");
            Console.WriteLine($"Number of 'l' in the string: {input.Count(c => c == 'l')}");
            Console.WriteLine($"Formatted output: {string.Join("*", input.ToCharArray())}");
        }

        void A3()
        {
            string filePath = "output.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Current contents of the file:");
                Console.WriteLine(File.ReadAllText(filePath));
            }
            else
            {
                Console.WriteLine("File does not exist. A new file will be created.");
            }

            Console.Write("Enter a string to append to the file: ");
            string input = Console.ReadLine();
            File.AppendAllText(filePath, input + Environment.NewLine);

            Console.WriteLine("String appended to the file successfully.");
            Console.WriteLine("Updated contents of the file:");
            Console.WriteLine(File.ReadAllText(filePath));
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Typecast Input");
                Console.WriteLine("2. String Manipulation");
                Console.WriteLine("3. Append to File");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        program.A1();
                        break;
                    case "2":
                        program.A2();
                        break;
                    case "3":
                        program.A3();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
