namespace CalculatorLibrary
{
    public class Calculator
    {

        // methods to handle calculations work
        public static void MakeSum(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames)
        {
            double total;
            string mathGame;

            total = firstNumber + secondNumber;

            mathGame = string.Format($"{firstNumber} + {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");
            Console.WriteLine();
        }

        public static void MakeSubtraction(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames)
        {
            double total;
            string mathGame;

            total = firstNumber - secondNumber;

            mathGame = string.Format($"{firstNumber} - {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} - {secondNumber} = {total}");
            Console.WriteLine();
        }
        public static void MakeMultiplication(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames)
        {
            double total;
            string mathGame;

            total = firstNumber * secondNumber;

            mathGame = string.Format($"{firstNumber} * {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} * {secondNumber} = {total}");
            Console.WriteLine();
        }

        public static void MakeDivisionForIntegers(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames)
        {
            double total;
            string mathGame;

            total = firstNumber / secondNumber;

            mathGame = string.Format($"{firstNumber} / {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} / {secondNumber} = {total}");
            Console.WriteLine();
        }

        public static void MakeSquare(double firstNumber, int mathCalculations, string[] mathGames)
        {
            double total;
            string mathGame;

            total = firstNumber * firstNumber;

            mathGame = string.Format($"{firstNumber} * {firstNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} * {firstNumber} = {total}");
            Console.WriteLine();
        }

        public static void EvenOrOdd(double firstNumber)
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

        public static void DisplayLatestMathCalculations(int mathCalculations, string[] mathGames)
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
                    Console.WriteLine();
                    Console.Write($"\t{mathGames[i]}");
                }
            }
        }

        // public static int DeleteLatestMathCalculations(int mathCalculations, string[] mathGames, int[,] scores, string[] mathOperations)
        // {

        //     // TODO: Ask only if array is not null
        //     Console.Write($"Do you want to delete some or all calculations? y or n?");

        //     if (Console.ReadLine() == "y")
        //     {
        //         Console.Write("Press 'd' to delete all the calculations ");
        //         Console.Write("Or press any other key and Enter to delete only specifics calculations: ");

        //         if (Console.ReadLine() == "d")
        //         {

        //             for (int j = 0; j < scores.Length / 2; j++)
        //             {
        //                 Console.WriteLine();
        //                 scores.SetValue(null, j, 1);
        //                 Console.Write($"\t{scores[j, 1]}\n");

        //             }

        //             for (int i = 0; i < mathGames.Length; i++)
        //             {
        //                 if (mathGames[i] != null)
        //                 {
        //                     // "delete" the array
        //                     mathGames.SetValue(null, i);
        //                     mathCalculations--;
        //                 }
        //             }
        //         }


        //         for (int i = 0; i < mathGames.Length; i++)
        //         {
        //             if (mathGames[i] != null)
        //             {
        //                 // Wait for the user to respond before closing.
        //                 Console.Write($"Press 'x' to delete the {mathGames[i]} calculation, or press any other key and Enter to continue: ");

        //                 if (Console.ReadLine() == "x")
        //                 {
        //                     // "delete" the item 
        //                     mathGames.SetValue(null, i);
        //                     mathCalculations--;
        //                     Console.WriteLine(i);

        //                     // Console.WriteLine($"score {scores[i, 1]}");
        //                     // scores.SetValue(scores[i, 1] - 1, i, 1);
        //                     // Console.WriteLine($"score {scores[i, 1]}");

        //                     // for (int j = 0; j < scores.Length / 2; j++)
        //                     // {
        //                     //     Console.WriteLine();
        //                     //     scores.SetValue(scores[j, 1] - 1, j, 1);
        //                     //     Console.Write($"\t{scores[j, 1]}\n");

        //                     // }

        //                 }


        //             }
        //         }
        //     }
        //     Console.WriteLine("\n"); // Friendly linespacing.

        //     return mathCalculations;
        // }


        public static void DisplayTotalMathCalculations(int mathCalculations, int[,] scores, string[] mathOperations, int answerForSum, int answerForSubtraction, int answerForMultiplication, int answerForDivision, int answerForSquare)
        {
            Console.WriteLine($"Total Math Calculations:\t\t{mathCalculations}");
            Console.WriteLine();

            for (int i = 0; i < scores.Length / 2; i++)
            {
                Console.WriteLine();
                Console.Write($"\t{mathOperations[i]}");
                Console.Write($"\t{scores[i, 1]}\n");

            }

            // Console.WriteLine($"\tTotal for Addition:\t\t{answerForSum}");
            // Console.WriteLine($"\tTotal for Subtraction:\t\t{answerForSubtraction}");
            // Console.WriteLine($"\tTotal for Multiplication:\t{answerForMultiplication}");
            // Console.WriteLine($"\tTotal for Division:\t\t{answerForDivision}");
            // Console.WriteLine($"\tTotal for SquareRoot:\t\t{answerForSquare}");

        }

        // public static int DeleteScoresMathCalculations(int mathCalculations, string[] mathGames, int[,] scores, string[] mathOperations)
        // {

        //     for (int i = 0; i < scores.Length / 2; i++)
        //     {
        //         // Wait for the user to respond before closing.
        //         Console.Write($"Press 'x' to delete the {scores[i, 1]}, or press any other key and Enter to continue: ");

        //         if (Console.ReadLine() == "x")
        //         {
        //             // "delete" the item 
        //             Console.WriteLine();
        //             Console.Write($"\t{mathOperations[i]}");
        //             scores.SetValue(scores[i, 1] - 1, i, 1);
        //             Console.Write($"\t{scores[i, 1]}\n");
        //         }

        //     }

        //     return mathCalculations;
        // }
    }
}