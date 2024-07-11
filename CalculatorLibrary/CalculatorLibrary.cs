namespace CalculatorLibrary
{
    public class Calculator
    {
        // methods to handle calculations work
        public static int MakeSum(int counter, double firstNumber, double secondNumber, string[] mathGames, double total, string mathGame, int answerForSum, int[,] scores)
        {

            answerForSum = scores[0, 1];

            answerForSum++;

            scores[0, 1] = answerForSum;

            total = firstNumber + secondNumber;

            mathGame = string.Format($"{firstNumber} + {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");
            return answerForSum;
        }

        public static int MakeSubtraction(int counter, double firstNumber, double secondNumber, string[] mathGames, double total, string mathGame, int answerForSubtraction, int[,] scores)
        {
            answerForSubtraction = scores[1, 1];

            answerForSubtraction++;

            scores[1, 1] = answerForSubtraction;

            total = firstNumber - secondNumber;

            mathGame = string.Format($"{firstNumber} - {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} - {secondNumber} = {total}");
            return answerForSubtraction;
        }
        public static int MakeMultiplication(int counter, double firstNumber, double secondNumber, string[] mathGames, double total, string mathGame, int answerForMultiplication, int[,] scores)
        {
            answerForMultiplication = scores[2, 1];

            answerForMultiplication++;

            scores[2, 1] = answerForMultiplication;

            total = firstNumber * secondNumber;

            mathGame = string.Format($"{firstNumber} * {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} * {secondNumber} = {total}");
            return answerForMultiplication;
        }

        public static int MakeDivisionForIntegers(int counter, double firstNumber, double secondNumber, string[] mathGames, double total, string mathGame, int answerForDivision, int[,] scores)
        {
            answerForDivision = scores[3, 1];

            answerForDivision++;

            scores[3, 1] = answerForDivision;

            total = firstNumber / secondNumber;

            mathGame = string.Format($"{firstNumber} / {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} / {secondNumber} = {total}");
            return answerForDivision;
        }

        public static int MakeSquare(int counter, double firstNumber, string[] mathGames, double total, string mathGame, int answerForSquare, int[,] scores)
        {
            /*
           What is Square Root in Math? The square root of a number is a number that when multiplied by itself gives the actual number. 
           For example, 2 is the square root of 4, and this is expressed as √4 = 2. 
           This means when 2 is multiplied by 2 it results in 4 and this can be verified as 2 × 2 = 4.
           */

            answerForSquare = scores[4, 1];

            answerForSquare++;

            scores[4, 1] = answerForSquare;

            total = Math.Sqrt(firstNumber);

            mathGame = string.Format($"{total} is the square root of {firstNumber}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{total} is the square root of {firstNumber}");
            return answerForSquare;
        }

        public static void EvenOrOdd(double firstNumber)
        {
            if (firstNumber % 2 == 0)
            {
                // save on math games
                Console.WriteLine($"{firstNumber} is an even number");
            }
            else
            {
                // save on math games
                Console.WriteLine($"{firstNumber} is an odd number");
            }
        }

        public static string[] DisplayLatestMathCalculations(int mathCalculations, string[] mathGames)
        {
            Console.WriteLine();
            Console.WriteLine($"You have done {mathCalculations} Calculations");
            Console.WriteLine();
            Console.WriteLine("Previus Math Calculations:");
            Console.WriteLine();

            for (int i = 0; i < mathGames.Length; i++)
            {
                if (mathGames[i] != null)
                {
                    Console.Write($"\t{mathGames[i]}");
                    Console.WriteLine();
                }
            }
            return mathGames;
        }

        public static void DisplayTotalMathCalculations(int mathCalculations, int[,] scores, string[] mathOperations, int answerForSum, int answerForSubtraction, int answerForMultiplication, int answerForDivision, string[] mathGames)
        {
            Console.WriteLine($"Total Math Calculations:\t\t{mathCalculations}");
            Console.WriteLine();

            for (int i = 0; i < scores.Length / 2; i++)
            {
                Console.WriteLine();
                Console.Write($"\t{mathOperations[i]}");
                Console.Write($"\t{scores[i, 1]}\n");
            }

            string[] addition = new string[10];
            string[] subtraction = new string[10];
            string[] multiplication = new string[10];
            string[] division = new string[10];
            string[] squareRoot = new string[10];

            int counterForSum = 0;
            int counterForSubtraction = 0;
            int counterForMultiplication = 0;
            int counterForDivision = 0;
            int counterForSquareRoot = 0;


            foreach (string game in mathGames)
            {
                if (game != null)
                {
                    string checkOperation = game;

                    if (checkOperation.Contains("+")) checkOperation = "Addition";
                    if (checkOperation.Contains("-")) checkOperation = "Subtraction";
                    if (checkOperation.Contains("*")) checkOperation = "Multiplication";
                    if (checkOperation.Contains("/")) checkOperation = "Division";
                    if (checkOperation.Contains("square root")) checkOperation = "SquareRoot";

                    switch (checkOperation)
                    {
                        case "Addition":
                            counterForSum++;
                            addition[counterForSum] = game;
                            break;

                        case "Subtraction":
                            counterForSubtraction++;
                            subtraction[counterForSubtraction] = game;
                            break;

                        case "Multiplication":
                            counterForMultiplication++;
                            multiplication[counterForMultiplication] = game;
                            break;

                        case "Division":
                            counterForDivision++;
                            division[counterForDivision] = game;
                            break;

                        case "SquareRoot":
                            counterForSquareRoot++;
                            squareRoot[counterForSquareRoot] = game;
                            break;
                    }
                }
            }
            Console.WriteLine();

            // want to see calculations by operation?
            Console.WriteLine(" To display the Addition Calculations , type: A");
            Console.WriteLine(" To display the Subtraction Calculations , type: S");
            Console.WriteLine(" To display the Multiplication Calculations , type: M");
            Console.WriteLine(" To display the Division Calculations , type: D");
            Console.WriteLine(" To display the Square Root Calculations , type: R");
            Console.WriteLine();
            Console.WriteLine("Enter your option (or type Exit to exit the program)");
            Console.WriteLine();

            string? readCalcInput;
            readCalcInput = Console.ReadLine();
            var acceptableCalculationOption = "A S M D R".Split();

            if (readCalcInput != null)
            {
                // validate for menu options
                while (!acceptableCalculationOption.Contains(readCalcInput))
                {
                    Console.WriteLine("Enter your option (or type Exit to exit the program)");
                    Console.WriteLine();
                    readCalcInput = Console.ReadLine();
                }

                switch (readCalcInput)
                {
                    case "A":
                        Console.WriteLine("Addition");
                        for (int i = 0; i < addition.Length; i++)
                        {
                            if (addition[i] != null)
                            {
                                Console.Write($"\t{addition[i]}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "S":
                        Console.WriteLine("Subtraction");
                        for (int i = 0; i < subtraction.Length; i++)
                        {
                            if (subtraction[i] != null)
                            {
                                Console.Write($"\t{subtraction[i]}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "M":
                        Console.WriteLine("Multiplication");
                        for (int i = 0; i < multiplication.Length; i++)
                        {
                            if (multiplication[i] != null)
                            {
                                Console.Write($"\t{multiplication[i]}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "D":
                        Console.WriteLine("Division");
                        for (int i = 0; i < division.Length; i++)
                        {
                            if (division[i] != null)
                            {
                                Console.Write($"\t{division[i]}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "R":
                        Console.WriteLine("Square Root");
                        for (int i = 0; i < squareRoot.Length; i++)
                        {
                            if (squareRoot[i] != null)
                            {
                                Console.Write($"\t{squareRoot[i]}");
                                Console.WriteLine();
                            }
                        }
                        break;
                }

            }
        }
        public static int DeleteLatestMathCalculations(int mathCalculations, string[] mathGames, int[,] scores, int answerForSum, int answerForSubtraction, int answerForMultiplication, int answerForDivision, int answerForSquare, string[] mathOperations)
        {
            // bool operationToDelete = false;

            // TODO: Ask only if array is not null or empty
            // Console.WriteLine(mathGames?.Any() != null);
            // Console.WriteLine(!mathGames.Any());
            // Console.WriteLine(mathGames == null);
            // Console.WriteLine(mathGames?.Length);

            // IsNullOrEmpty - equivalent for Array? 
            // if (mathGames == IsNullOrEmpty)
            // {
            //     Console.Write("There is no calculations to delete.");
            // }

            Console.Write($"Do you want to delete some or all calculations? y or n?");

            if (Console.ReadLine() == "y")
            {
                Console.Write("Press 'd' to delete all the calculations ");
                Console.Write("Or press any other key and Enter to delete only specifics calculations: ");

                if (Console.ReadLine() == "d")
                {
                    for (int i = 0; i < mathGames?.Length; i++)
                    {
                        if (mathGames[i] != null)
                        {
                            // "delete" the array
                            mathGames.SetValue(null, i);
                            mathCalculations--;
                        }
                    }

                    for (int i = 0; i < scores.Length / 2; i++)
                    {
                        if (scores[i, 1] != 0)
                        {
                            // "delete" the array
                            scores.SetValue(0, i, 1);
                        }
                    }
                }

                for (int i = 0; i < mathGames?.Length; i++)
                {
                    if (mathGames[i] != null)
                    {
                        string checkOperation = mathGames[i];

                        Console.Write($"Press 'x' to delete the {mathGames[i]} calculation, or press any other key and Enter to continue: ");

                        if (Console.ReadLine() == "x")
                        {
                            // delete element from mathGames array
                            // check .Remove
                            mathGames.SetValue(null, i);
                            mathCalculations--;

                            if (checkOperation.Contains("+"))
                            {
                                //delete element from scores array
                                answerForSum--;
                                scores[0, 1] = answerForSum;
                            }
                            else
                            {
                                if (checkOperation.Contains("-"))
                                {
                                    answerForSubtraction--;
                                    scores[1, 1] = answerForSubtraction;
                                }
                                if (checkOperation.Contains("*"))
                                {
                                    answerForMultiplication--;
                                    scores[2, 1] = answerForMultiplication;
                                }
                                if (checkOperation.Contains("/"))
                                {
                                    answerForDivision--;
                                    scores[3, 1] = answerForDivision;
                                }
                                if (checkOperation.Contains("square root"))
                                {
                                    answerForSquare--;
                                    scores[4, 1] = answerForSquare;
                                }
                                // if even or odd
                            }
                        }
                    }
                }
            }
            return mathCalculations;
        }
    }
}