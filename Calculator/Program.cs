
using System.Text.RegularExpressions;

// To resolve the ambiguity, rename the namespace from Calculator to CalculatorProgram in Program.cs.
namespace CalculatorProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? firstNumberInput = "";
            string? secondNumberInput = "";

            int correctAnswer = 0;

            double total = 0;

            int correctAnswerForSum = 0;
            int correctAnswerForSubtraction = 0;
            int correctAnswerForMultiplication = 0;
            int correctAnswerForDivision = 0;
            int correctAnswerForSquare = 0;

            string? readResult = "";
            string menuSelection = "";
            string mathGame = "";

            int[,] scores = new int[,] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };
            string[] mathOperations = new string[] { "Addition", "Subtraction", "Multiplication", "Division", "Square2d" };
            string[] mathGames = new string[33];

            int counter = 0;
            int rounds = 0;
            int mathCalculations = 0;

            double firstNumber = 0;
            double secondNumber = 0;

            // handles user interface and error-handling work
            while (menuSelection != "exit")
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Calculator app in C#");
                Console.WriteLine("------------------------\n");

                // Ask the user to choose an operation.
                Console.WriteLine("Your main menu options are:");
                Console.WriteLine("------------------------\n");
                Console.WriteLine("1. To calculate the Addition of two integers, type: 1");
                Console.WriteLine("2. To calculate the Subtraction of two integers, type: 2");
                Console.WriteLine("3. To calculate the Multiplication of two integers, type: 3");
                Console.WriteLine("4. To calculate the Division of two decimals (2 digits rounded), type: 4");
                Console.WriteLine("5. To calculate the Division of two integers, type: 5");
                Console.WriteLine("6. To calculate the Square Root of one integer, type: 6");
                Console.WriteLine("7. To check if one integer is Even or Odd, type: 7");

                Console.WriteLine("8. To display the total Math Calculations by operation, type: 8");
                Console.WriteLine("9. To display the previous Math Calculations, type: 9");

                var currentDate = DateTime.Now;
                Console.WriteLine($"{Environment.NewLine}Hello! on {currentDate:d} at {currentDate:t}");

                Console.WriteLine("Enter your option (or type Exit to exit the program)");
                Console.WriteLine();

                Regex menuOptions = new Regex(@"[A-Z1-9]\d$");

                readResult = Console.ReadLine();

                // TODO: validate for option 0 
                // || (readResult == "0") ---  && (readResult != "0")
                if (readResult != null)
                {
                    // validate for input string
                    while (!double.TryParse(readResult, out firstNumber))
                    {
                        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                        readResult = Console.ReadLine();
                    }

                    menuSelection = readResult.ToLower();

                    // TODO: validate range of options from 0 to 9
                    // (Regex.IsMatch(menuSelection, @"[A-Z0-9]\d")))
                    if (!menuOptions.IsMatch(menuSelection) == true)
                    {
                        if (menuSelection == "7")
                        {
                            // Ask the user to type the first number.
                            Console.WriteLine("Type a number to check if is even or odd, and then press Enter:");
                            firstNumberInput = Console.ReadLine();

                            // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                            while (!double.TryParse(firstNumberInput, out firstNumber))
                            {
                                Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                                firstNumberInput = Console.ReadLine();
                            }
                        }
                        else if (menuSelection == "6")
                        {
                            Console.WriteLine("Square Root");

                            // Ask the user to type the first number.
                            Console.WriteLine("Type a number to Calculate the Square Root, and then press Enter:");
                            firstNumberInput = Console.ReadLine();

                            // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                            while (!double.TryParse(firstNumberInput, out firstNumber))
                            {
                                Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                                firstNumberInput = Console.ReadLine();
                            }
                        }
                        else if (menuSelection != "9" && menuSelection != "8")
                        {
                            // Ask the user to type the first number.
                            Console.WriteLine("Type a number, and then press Enter:");
                            firstNumberInput = Console.ReadLine();

                            // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                            while (!double.TryParse(firstNumberInput, out firstNumber))
                            {
                                Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                                firstNumberInput = Console.ReadLine();
                            }

                            // Ask the user to type the second number.
                            Console.WriteLine("Type another number, and then press Enter:");
                            secondNumberInput = Console.ReadLine();

                            while (!double.TryParse(secondNumberInput, out secondNumber))
                            {
                                Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
                                secondNumberInput = Console.ReadLine();
                            }
                        }
                    }
                }
                // handles user interface
                switch (menuSelection)
                {
                    case "1":
                        Console.WriteLine("Addition");

                        mathCalculations++;
                        // counter++;

                        // MakeSum(firstNumber, secondNumber);
                        total = CalculatorLibrary.Calculator.MakeSum(firstNumber, secondNumber, mathCalculations, mathGames);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Subtraction");

                        mathCalculations++;

                        // MakeSubtraction(firstNumber, secondNumber);
                        total = CalculatorLibrary.Calculator.MakeSubtraction(firstNumber, secondNumber, mathCalculations, mathGames);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Multiplication");

                        mathCalculations++;

                        // MakeMultiplication(firstNumber, secondNumber);
                        total = CalculatorLibrary.Calculator.MakeMultiplication(firstNumber, secondNumber, mathCalculations, mathGames);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("Divion for decimals");

                        mathCalculations++;

                        // MakeDivisionForDecimals(firstNumber, secondNumber);
                        // total = CalculatorLibrary.Calculator.MakeDivisionForDecimals(firstNumber, secondNumber, total);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine("Division for integers");

                        mathCalculations++;

                        // MakeDivisionForIntegers(firstNumber, secondNumber);
                        // total = CalculatorLibrary.Calculator.MakeDivisionForIntegers(firstNumber, secondNumber, total);

                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine("Square Root");

                        mathCalculations++;

                        // MakeSquare(firstNumber);

                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine("Even or Odd");

                        // evenOrOdd(firstNumber);

                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine($"Total Math Calculations:\t\t{correctAnswer}");
                        Console.WriteLine();

                        Console.WriteLine($"\tTotal for Addition:\t\t{correctAnswerForSum}");
                        Console.WriteLine($"\tTotal for Subtraction:\t\t{correctAnswerForSubtraction}");
                        Console.WriteLine($"\tTotal for Multiplication:\t{correctAnswerForMultiplication}");
                        Console.WriteLine($"\tTotal for Division:\t\t{correctAnswerForDivision}");
                        Console.WriteLine($"\tTotal for SquareRoot:\t\t{correctAnswerForSquare}");

                        for (int i = 0; i < scores.Length / 2; i++)
                        {
                            Console.WriteLine();
                            Console.Write($"\t{mathOperations[i]}");
                            Console.Write($"\t{scores[i, 1]}\n");

                        }
                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "9":
                        Console.WriteLine($"You have done {mathCalculations} Calculations");
                        Console.WriteLine();
                        Console.WriteLine("Previus Math Calculations:");
                        Console.WriteLine();



                        // DisplayLatestMathCalculations();
                        // DeleteLatestMathCalculations();

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                }
            }


        }
    }
}

// class to handle user interface

// class to handle calculations
// class Calculator
//  
