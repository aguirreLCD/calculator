namespace CalculatorLibrary
{
    public class Calculator
    {
        // methods to handle calculations work
        public static void MakeSum(int counter, double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, double total, string mathGame)
        {

            Console.WriteLine(counter);
            // Console.WriteLine(mathCalculations);

            total = firstNumber + secondNumber;

            mathGame = string.Format($"{firstNumber} + {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");
            Console.WriteLine();
        }

        public static void MakeSubtraction(int counter, double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, double total, string mathGame)
        {
            Console.WriteLine(counter);

            total = firstNumber - secondNumber;

            mathGame = string.Format($"{firstNumber} - {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} - {secondNumber} = {total}");
            Console.WriteLine();
        }
        public static void MakeMultiplication(int counter, double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, double total, string mathGame)
        {

            Console.WriteLine(counter);

            total = firstNumber * secondNumber;

            mathGame = string.Format($"{firstNumber} * {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} * {secondNumber} = {total}");
            Console.WriteLine();
        }

        public static void MakeDivisionForIntegers(int counter, double firstNumber, double secondNumber, int mathCalculations, string[] mathGames, double total, string mathGame)
        {

            total = firstNumber / secondNumber;

            mathGame = string.Format($"{firstNumber} / {secondNumber} = {total}");
            mathGames[counter] = mathGame;

            Console.WriteLine($"{firstNumber} / {secondNumber} = {total}");
            Console.WriteLine();
        }

        public static void MakeSquare(int counter, double firstNumber, int mathCalculations, string[] mathGames, double total, string mathGame)
        {

            total = firstNumber * firstNumber;

            mathGame = string.Format($"{firstNumber} * {firstNumber} = {total}");
            mathGames[counter] = mathGame;

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


        public static void DisplayTotalMathCalculations(int mathCalculations, int[,] scores, string[] mathOperations)
        {
            Console.WriteLine($"Total Math Calculations:\t\t{mathCalculations}");
            Console.WriteLine();

            for (int i = 0; i < scores.Length / 2; i++)
            {
                Console.WriteLine();
                Console.Write($"\t{mathOperations[i]}");
                Console.Write($"\t{scores[i, 1]}\n");

            }
            // return scores;
        }

        public static int DeleteLatestMathCalculations(int mathCalculations, string[] mathGames, int[,] scores)
        {
            bool operationToDelete = false;
            // TODO: Ask only if array is not null
            Console.Write($"Do you want to delete some or all calculations? y or n?");

            if (Console.ReadLine() == "y")
            {
                Console.Write("Press 'd' to delete all the calculations ");
                Console.Write("Or press any other key and Enter to delete only specifics calculations: ");

                if (Console.ReadLine() == "d")
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
                            Console.WriteLine(mathGames[i]);

                            mathGames.SetValue(null, i);
                            mathCalculations--;
                            operationToDelete = true;
                            Console.WriteLine(mathGames[i]);
                            Console.WriteLine(i);
                        }



                    }
                }

                if (operationToDelete == true)
                {
                    for (int j = 0; j < scores.Length / 2; j++)
                    {

                        // "delete" the item 
                        // mathCalculations = mathCalculations - scores[j, 1];
                        // Console.WriteLine();
                        scores.SetValue(scores[j, 1] - 1, j, 1);
                        // Console.Write($"\t{scores[i, 1]}\n");
                    }
                }

            }
            Console.WriteLine("\n"); // Friendly linespacing.
            return mathCalculations;
        }


        public static int DeleteScoresMathCalculations(int mathCalculations, string[] mathGames, int[,] scores, string[] mathOperations)
        {
            Console.WriteLine($"Total Math Calculations:\t\t{mathCalculations}");
            Console.WriteLine();

            for (int i = 0; i < scores.Length / 2; i++)
            {
                Console.WriteLine();
                Console.Write($"\t{mathOperations[i]}");
                Console.Write($"\t{scores[i, 1]}\n");
            }

            Console.Write($"Do you want to delete some operation? y or n?");

            if (Console.ReadLine() == "y")
            {
                for (int i = 0; i < scores.Length / 2; i++)
                {
                    // Wait for the user to respond before closing.
                    Console.Write($"Press 'x' to delete all the {mathOperations[i]} operations, or press any other key and Enter to continue: ");

                    if (Console.ReadLine() == "x")
                    {
                        // "delete" the item 
                        mathCalculations = mathCalculations - scores[i, 1];
                        Console.WriteLine();
                        Console.Write($"\t{mathOperations[i]}");
                        scores.SetValue(0, i, 1);
                        Console.Write($"\t{scores[i, 1]}\n");
                    }
                }
            }




            return mathCalculations;
        }
    }
}