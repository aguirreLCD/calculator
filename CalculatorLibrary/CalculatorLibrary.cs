namespace CalculatorLibrary
{
    public class Calculator
    {
        // methods to handle calculations work
        public static double MakeSum(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, int answerForSum, int[,] scores)
        {

            double total = 0;
            string mathGame = "";

            total = firstNumber + secondNumber;

            mathGame = string.Format($"{firstNumber} + {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");

            answerForSum++;
            scores[0, 1] = answerForSum;

            Console.WriteLine();
            return total;
        }
        public static double MakeSubtraction(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, int answerForSubtraction, int[,] scores)
        {

            double total = 0;
            string mathGame = "";

            total = firstNumber - secondNumber;

            mathGame = string.Format($"{firstNumber} - {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} - {secondNumber} = {total}");

            answerForSubtraction++;
            scores[1, 1] = answerForSubtraction;

            Console.WriteLine();
            return total;

        }
        public static double MakeMultiplication(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, int answerForMultiplication, int[,] scores)
        {

            double total = 0;
            string mathGame = "";

            total = firstNumber * secondNumber;

            mathGame = string.Format($"{firstNumber} * {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} * {secondNumber} = {total}");

            answerForMultiplication++;
            scores[2, 1] = answerForMultiplication;

            Console.WriteLine();
            return total;
        }
        public static double MakeDivisionForIntegers(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, int answerForDivision, int[,] scores)
        {
            double total = 0;
            string mathGame = "";

            total = firstNumber / secondNumber;

            mathGame = string.Format($"{firstNumber} / {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} / {secondNumber} = {total}");

            answerForDivision++;
            scores[3, 1] = answerForDivision;

            Console.WriteLine();
            return total;
        }
        public static double MakeSquare(double firstNumber, int mathCalculations, string[] mathGames, int answerForSquare, int[,] scores)
        {
            double total = 0;
            string mathGame = "";

            total = firstNumber * firstNumber;

            mathGame = string.Format($"{firstNumber} * {firstNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} * {firstNumber} = {total}");

            answerForSquare++;
            scores[4, 1] = answerForSquare;

            Console.WriteLine();
            return total;
        }
        public static double EvenOrOdd(double firstNumber)
        {
            double total = 0;

            if (firstNumber % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} is an even number");
            }
            else
            {
                Console.WriteLine($"{firstNumber} is an odd number");
            }
            return total;
        }

        public static string DisplayLatestMathCalculations(int mathCalculations, string[] mathGames)
        {
            string mathGame = "";
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
            return mathGame;
        }

        // public void DeleteLatestMathCalculations()
        // {
        //     string deleteBtn = "x";

        //     for (int i = 0; i < mathGames.Length; i++)
        //     {
        //         if (mathGames[i] != null)
        //         {
        //             Console.WriteLine();
        //             Console.Write($"\t{mathGames[i]}");
        //             Console.Write($"\t{deleteBtn}\n");
        //         }
        //     }

        //     // TODO: Ask only if array is not null
        //     Console.Write($"Do you want to delete some or all calculations? y or n?");

        //     if (Console.ReadLine() == "y")
        //     {
        //         Console.Write($"Press 'd' to delete all the calculations, or press any other key and Enter to delete only specifics calculations: ");
        //         if (Console.ReadLine() == "d")
        //         {
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
        //                     // Console.WriteLine();
        //                     mathGames.SetValue(null, i);
        //                     mathCalculations--;
        //                 }
        //             }
        //         }
        //     }
        //     Console.WriteLine("\n"); // Friendly linespacing.
        // }


    }

}