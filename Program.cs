
using System.Text.RegularExpressions;

string? firstNumberInput = "";
string? secondNumberInput = "";

int correctAnswer = 0;

float total = 0;

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

float firstNumber = 0;
float secondNumber = 0;

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

    Console.WriteLine();
    Console.WriteLine("Enter your option (or type Exit to exit the program)");

    Regex menuOptions = new Regex(@"[A-Z0-9]\d$");

    readResult = Console.ReadLine();

    // TODO: validate for option 0 
    // || (readResult == "0") ---  && (readResult != "0")
    if (readResult != null)
    {
        // validate for input string
        while (!float.TryParse(readResult, out firstNumber))
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
                while (!float.TryParse(firstNumberInput, out firstNumber))
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
                while (!float.TryParse(firstNumberInput, out firstNumber))
                {
                    Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                    firstNumberInput = Console.ReadLine();
                }
            }
            else if ((menuSelection != "9") && (menuSelection != "8"))
            {
                // Ask the user to type the first number.
                Console.WriteLine("Type a number, and then press Enter:");
                firstNumberInput = Console.ReadLine();

                // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
                while (!float.TryParse(firstNumberInput, out firstNumber))
                {
                    Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                    firstNumberInput = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.WriteLine("Type another number, and then press Enter:");
                secondNumberInput = Console.ReadLine();

                while (!float.TryParse(secondNumberInput, out secondNumber))
                {
                    Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
                    secondNumberInput = Console.ReadLine();
                }
            }
        }
    }

    switch (menuSelection)
    {
        case "1":
            Console.WriteLine("Addition");

            mathCalculations++;

            MakeSum(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            Console.WriteLine("Subtraction");

            mathCalculations++;

            MakeSubtraction(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            Console.WriteLine("Multiplication");

            mathCalculations++;

            MakeMultiplication(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("Divion for decimals");

            mathCalculations++;

            MakeDivisionForDecimals(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("Division for integers");

            mathCalculations++;

            MakeDivisionForIntegers(firstNumber, secondNumber);

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("Square Root");

            mathCalculations++;

            MakeSquare(firstNumber);

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("Even or Odd");

            evenOrOdd(firstNumber);

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
            DeleteLatestMathCalculations();

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
    }
}

void MakeSum(float firstNumber, float secondNumber)
{
    rounds--;
    counter++;

    total = firstNumber + secondNumber;

    mathGame = String.Format($"{firstNumber} + {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");

    correctAnswer++;
    correctAnswerForSum++;

    scores[0, 1] = correctAnswerForSum;
    Console.WriteLine();
}

void MakeSubtraction(float firstNumber, float secondNumber)
{
    rounds--;
    counter++;

    total = firstNumber - secondNumber;

    mathGame = String.Format($"{firstNumber} - {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"{firstNumber} - {secondNumber} = {total}");

    correctAnswer++;
    correctAnswerForSubtraction++;

    scores[1, 1] = correctAnswerForSubtraction;
    Console.WriteLine();
}

void MakeMultiplication(float firstNumber, float secondNumber)
{
    rounds--;
    counter++;

    total = firstNumber * secondNumber;
    mathGame = String.Format($"{firstNumber} * {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"{firstNumber} * {secondNumber} = {total}");

    correctAnswer++;
    correctAnswerForMultiplication++;

    scores[2, 1] = correctAnswerForMultiplication;
    Console.WriteLine();
}

void MakeDivisionForDecimals(float firstNumber, float secondNumber)
{
    while (secondNumber == 0)
    {
        Console.WriteLine("Number mustn't be zero. Type another number, and then press Enter:");
        secondNumberInput = Console.ReadLine();

        while (!float.TryParse(secondNumberInput, out secondNumber))
        {
            Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
            secondNumberInput = Console.ReadLine();
        }
    }

    rounds--;
    counter++;

    total = firstNumber / secondNumber;
    double totalRounded = Math.Round(total, 2);

    mathGame = String.Format($"{firstNumber} / {secondNumber} = {totalRounded}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"{firstNumber} / {secondNumber} = {totalRounded}");

    correctAnswer++;
    correctAnswerForDivision++;

    scores[3, 1] = correctAnswerForDivision;
    Console.WriteLine();
}

void MakeDivisionForIntegers(float firstNumber, float secondNumber)
{
    while (secondNumber == 0)
    {
        Console.WriteLine("Number mustn't be zero. Type another number, and then press Enter:");
        secondNumberInput = Console.ReadLine();

        while (!float.TryParse(secondNumberInput, out secondNumber))
        {
            Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
            secondNumberInput = Console.ReadLine();
        }
    }

    rounds--;
    counter++;

    total = firstNumber / secondNumber;

    mathGame = String.Format($"{firstNumber} / {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"{firstNumber} / {secondNumber} = {total}");

    correctAnswer++;
    correctAnswerForDivision++;

    scores[3, 1] = correctAnswerForDivision;
    Console.WriteLine();
}

void MakeSquare(float firstNumber)
{
    rounds--;
    counter++;

    total = firstNumber * firstNumber;

    mathGame = String.Format($"{firstNumber} * {firstNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"{firstNumber} * {firstNumber} = {total}");
    correctAnswer++;
    correctAnswerForSquare++;

    scores[4, 1] = correctAnswerForSquare;
    Console.WriteLine();
}

void evenOrOdd(float firstNumber)
{
    if (firstNumber % 2 == 0)
    {
        Console.WriteLine($"{firstNumber} is an even number");
    }
    else
    {
        Console.WriteLine($"{firstNumber} is an odd number");
    }
}


void DisplayLatestMathCalculations()
{
    string deleteBtn = "X";

    for (int i = 0; i < mathGames.Length; i++)
    {
        if (mathGames[i] != null)
        {
            // Console.WriteLine(mathGames[i]);
            Console.WriteLine();
            Console.Write($"\t{mathGames[i]}");
            Console.Write($"\t{deleteBtn}\n");
        }
        // Console.WriteLine(Console.ReadKey());
    }
}

void DeleteLatestMathCalculations()
{

    string deleteBtn = "x";

    for (int i = 0; i < mathGames.Length; i++)
    {
        if (mathGames[i] != null)
        {
            Console.WriteLine();
            Console.Write($"\t{mathGames[i]}");
            Console.Write($"\t{deleteBtn}\n");
        }
    }

    Console.Write($"Press 'y' to delete all the calculations, or press any other key and Enter to delete specific calculation: ");
    if (Console.ReadLine() == "y")
    {
        for (int i = 0; i < mathGames.Length; i++)
        {
            if (mathGames[i] != null)
            {
                // "delete" the array
                mathGames.SetValue(null, i);
                mathCalculations--;
            }
        }
    }

    for (int i = 0; i < mathGames.Length; i++)
    {
        if (mathGames[i] != null)
        {
            // Wait for the user to respond before closing.
            Console.Write($"Press 'x' to delete the {mathGames[i]} calculation, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "x")
            {
                // "delete" the item 
                Console.WriteLine();

                mathGames.SetValue(null, i);
                mathCalculations--;
            }
        }
    }

    Console.WriteLine("\n"); // Friendly linespacing.
}


