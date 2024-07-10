
namespace CalculatorProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? firstNumberInput;
            string? secondNumberInput;
            double firstNumber = 0;
            double secondNumber = 0;

            int mathCalculations = 0;
            double total = 0;

            int answerForSum = 0;
            int answerForSubtraction = 0;
            int answerForMultiplication = 0;
            int answerForDivision = 0;
            int answerForSquare = 0;

            string? readResult;
            string menuSelection = "";
            string mathGame = "";

            // 1 = Addition, 2 = Subtraction, 3 = Multiplication, 4 = Division, 5 = Square2d
            int[,] scores = new int[,] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };

            string[] mathOperations = new string[] { "Addition", "Subtraction", "Multiplication", "Division", "Square2d" };

            string[] mathGames = new string[33];


            int counter = 0;


            // handles user interface and error-handling work
            while (menuSelection != "exit")
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Calculator app in C#");
                Console.WriteLine("------------------------\n");

                // Ask the user to choose an operation.
                Console.WriteLine("Your main menu options are:");
                Console.WriteLine("------------------------\n");

                Console.WriteLine("1. To calculate the Addition, type: 1");
                Console.WriteLine("2. To calculate the Subtraction, type: 2");
                Console.WriteLine("3. To calculate the Multiplication, type: 3");
                Console.WriteLine("4. To calculate the Division, type: 4");

                Console.WriteLine("5. To calculate the Square Root, type: 5");
                Console.WriteLine("6. To check if one integer is Even or Odd, type: 6");

                Console.WriteLine("7. To display the total Math Calculations by operation, type: 7");
                Console.WriteLine("8. To display the previous Math Calculations, type: 8");

                var currentDate = DateTime.Now;
                Console.WriteLine($"{Environment.NewLine}Hello! on {currentDate:d} at {currentDate:t}");

                Console.WriteLine("Enter your option (or type Exit to exit the program)");
                Console.WriteLine();

                readResult = Console.ReadLine();
                var acceptableMenuOption = "0 1 2 3 4 5 6 7 8 9".Split();

                // String.IsNullOrEmpty(name)
                // if (!String.IsNullOrEmpty(readResult))
                if (readResult != null)
                {
                    // validate for menu options
                    while (!acceptableMenuOption.Contains(readResult))
                    {
                        Console.WriteLine("Enter your option (or type Exit to exit the program)");
                        Console.WriteLine();
                        readResult = Console.ReadLine();
                    }

                    // validate for input string
                    while (!double.TryParse(readResult, out firstNumber))
                    {
                        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                        readResult = Console.ReadLine();
                    }

                    menuSelection = readResult.ToLower();

                    // TODO: make a method that asks the user for a number - and just repeats the question if they don't enter a number 
                    if (menuSelection == "6") // Even or Odd
                    {
                        // Ask the user to type the first number.
                        Console.WriteLine("Type a number to check if is even or odd, and then press Enter:");
                        firstNumberInput = Console.ReadLine();

                        // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                        while (!double.TryParse(firstNumberInput, out firstNumber))
                        {
                            Console.WriteLine("This is not a valid input. Please enter a valid number and then press Enter:");
                            firstNumberInput = Console.ReadLine();
                        }
                    }
                    else if (menuSelection == "5") // Square Root
                    {
                        Console.WriteLine("Square Root");

                        // Ask the user to type the first number.
                        Console.WriteLine("Type a number to Calculate the Square Root, and then press Enter:");
                        firstNumberInput = Console.ReadLine();

                        // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                        while (!double.TryParse(firstNumberInput, out firstNumber))
                        {
                            Console.WriteLine("This is not a valid input. Please enter a valid number and then press Enter:");
                            firstNumberInput = Console.ReadLine();
                        }
                    }
                    else if (menuSelection == "4") // Division
                    {
                        // Ask the user to type the first number.
                        Console.WriteLine("Type the Dividend, and then press Enter:");
                        firstNumberInput = Console.ReadLine();

                        // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                        while (!double.TryParse(firstNumberInput, out firstNumber))
                        {
                            Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                            firstNumberInput = Console.ReadLine();
                        }
                        // Ask the user to type the second number.
                        Console.WriteLine("Type the Divisor, and then press Enter:");
                        secondNumberInput = Console.ReadLine();

                        while (!double.TryParse(secondNumberInput, out secondNumber))
                        {
                            Console.WriteLine("This is not a valid input. Please enter a valid divisor number and then press Enter:");
                            secondNumberInput = Console.ReadLine();
                        }
                        while (secondNumber == 0)
                        {
                            Console.WriteLine("Divisor mustn't be zero. Type another number, and then press Enter:");
                            secondNumberInput = Console.ReadLine();

                            while (!double.TryParse(secondNumberInput, out secondNumber))
                            {
                                Console.WriteLine("This is not a valid input. Please enter a valid divisor number and then press Enter:");
                                secondNumberInput = Console.ReadLine();
                            }
                        }
                    }
                    else if (menuSelection != "7" && menuSelection != "8" && menuSelection != "9" && menuSelection != "0") // Addition, Subtraction, Multiplication
                    {
                        // Ask the user to type the first number.
                        Console.WriteLine("Type a number, and then press Enter:");
                        firstNumberInput = Console.ReadLine();

                        // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                        while (!double.TryParse(firstNumberInput, out firstNumber))
                        {
                            Console.WriteLine("This is not a valid input. Please enter a valid number and then press Enter:");
                            firstNumberInput = Console.ReadLine();
                        }
                        // Ask the user to type the second number.
                        Console.WriteLine("Type another number, and then press Enter:");
                        secondNumberInput = Console.ReadLine();

                        while (!double.TryParse(secondNumberInput, out secondNumber))
                        {
                            Console.WriteLine("This is not a valid input. Please enter a valid number and then press Enter:");
                            secondNumberInput = Console.ReadLine();
                        }
                    }
                }
                // handles user interface
                switch (menuSelection)
                {
                    // case "0": // Delete Scores Math Calculations
                    //     mathCalculations = CalculatorLibrary.Calculator.DeleteScoresMathCalculations(mathCalculations, mathGames, scores, mathOperations);

                    //     Console.WriteLine("\n\rPress the Enter key to continue.");
                    //     readResult = Console.ReadLine();
                    //     break;

                    case "1": // Addition
                        Console.WriteLine("Addition");

                        counter++;
                        mathCalculations++;
                        // 
                        // answerForSum++;
                        // scores[0, 1] = answerForSum;

                        answerForSum = CalculatorLibrary.Calculator.MakeSum(counter, firstNumber, secondNumber, mathGames, total, mathGame, answerForSum, scores);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "2": // Subtraction
                        Console.WriteLine("Subtraction");

                        counter++;
                        mathCalculations++;

                        // answerForSubtraction++;
                        // scores[1, 1] = answerForSubtraction;

                        answerForSubtraction = CalculatorLibrary.Calculator.MakeSubtraction(counter, firstNumber, secondNumber, mathGames, total, mathGame, answerForSubtraction, scores);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "3": // Multiplication
                        Console.WriteLine("Multiplication");

                        counter++;
                        mathCalculations++;

                        // answerForMultiplication++;
                        // scores[2, 1] = answerForMultiplication;

                        answerForMultiplication = CalculatorLibrary.Calculator.MakeMultiplication(counter, firstNumber, secondNumber, mathGames, total, mathGame, answerForMultiplication, scores);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "4": // Division
                        Console.WriteLine("Division");

                        counter++;
                        mathCalculations++;

                        // answerForDivision++;
                        // scores[3, 1] = answerForDivision;

                        answerForDivision = CalculatorLibrary.Calculator.MakeDivisionForIntegers(counter, firstNumber, secondNumber, mathGames, total, mathGame, answerForDivision, scores);

                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "5": // Square Root
                        Console.WriteLine("Square Root");
                        counter++;

                        mathCalculations++;
                        answerForSquare++;
                        scores[4, 1] = answerForSquare;

                        CalculatorLibrary.Calculator.MakeSquare(counter, firstNumber, mathGames, total, mathGame);

                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "6": // Even or Odd
                        Console.WriteLine("Even or Odd");

                        CalculatorLibrary.Calculator.EvenOrOdd(firstNumber);

                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "7": // Display Total Math Calculations by Operations
                        CalculatorLibrary.Calculator.DisplayTotalMathCalculations(mathCalculations, scores, mathOperations, answerForSum, answerForSubtraction, answerForMultiplication, answerForDivision);

                        Console.WriteLine();
                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "8": // Display Latest Math Calculations
                        mathGames = CalculatorLibrary.Calculator.DisplayLatestMathCalculations(mathCalculations, mathGames);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "9": // Delete Latest Math Calculations
                              // TODO: Delete from scoresf
                        mathCalculations = CalculatorLibrary.Calculator.DeleteLatestMathCalculations(mathCalculations, mathGames, scores, answerForSum, answerForSubtraction, answerForMultiplication, answerForDivision, mathOperations);

                        Console.WriteLine("\n\rPress the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
