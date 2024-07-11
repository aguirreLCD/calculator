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
            Console.WriteLine();
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
            Console.WriteLine();
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
            Console.WriteLine();
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
            Console.WriteLine();
            return answerForDivision;
        }

        public static int MakeSquare(int counter, double firstNumber, string[] mathGames, double total, string mathGame, int answerForSquare, int[,] scores)
        {

            answerForSquare = scores[4, 1];

            answerForSquare++;

            scores[4, 1] = answerForSquare;

            /*
            // What is Square Root in Math? The square root of a number is a number that when multiplied by itself gives the actual number. 
            // For example, 2 is the square root of 4, and this is expressed as √4 = 2. This means when 2 is multiplied by 2 it results in 4 and this can be verified as 2 × 2 = 4.
            */

            total = Math.Sqrt(firstNumber);

            mathGame = string.Format($"{total} is the square root of {firstNumber}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{total} is the square root of {firstNumber}");
            Console.WriteLine();
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

        public static void DisplayTotalMathCalculations(int mathCalculations, int[,] scores, string[] mathOperations, int answerForSum, int answerForSubtraction, int answerForMultiplication, int answerForDivision)
        {
            Console.WriteLine($"Total Math Calculations:\t\t{mathCalculations}");
            Console.WriteLine();

            for (int i = 0; i < scores.Length / 2; i++)
            {
                Console.WriteLine();
                Console.Write($"\t{mathOperations[i]}");
                Console.Write($"\t{scores[i, 1]}\n");
            }
        }

        public static int DeleteLatestMathCalculations(int mathCalculations, string[] mathGames, int[,] scores, int answerForSum, int answerForSubtraction, int answerForMultiplication, int answerForDivision, string[] mathOperations)
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
                                // if square
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