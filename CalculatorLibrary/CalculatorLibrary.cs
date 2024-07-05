namespace CalculatorLibrary
{
    public class Calculator
    {

        // methods to handle calculations work
        public static double MakeSum(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames)
        {
            // rounds--;
            // counter++;
            double total = 0;
            string mathGame = "";


            total = firstNumber + secondNumber;

            mathGame = string.Format($"{firstNumber} + {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");

            // correctAnswer++;
            // correctAnswerForSum++;

            // scores[0, 1] = correctAnswerForSum;

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

            Console.WriteLine();

            return total;
        }

        public static double MakeSubtraction(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames)
        {
            // rounds--;
            // counter++;
            double total = 0;
            string mathGame = "";

            total = firstNumber - secondNumber;

            mathGame = string.Format($"{firstNumber} - {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} - {secondNumber} = {total}");

            // correctAnswer++;
            // correctAnswerForSubtraction++;

            // scores[1, 1] = correctAnswerForSubtraction;

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
            Console.WriteLine();

            return total;

        }

        public static double MakeMultiplication(double firstNumber, double secondNumber, int mathCalculations, string[] mathGames)
        {
            // rounds--;
            // counter++;
            double total = 0;
            string mathGame = "";

            total = firstNumber * secondNumber;

            mathGame = string.Format($"{firstNumber} * {secondNumber} = {total}");
            mathGames[mathCalculations] = mathGame;

            Console.WriteLine($"{firstNumber} * {secondNumber} = {total}");

            // correctAnswer++;
            // correctAnswerForMultiplication++;

            // scores[2, 1] = correctAnswerForMultiplication;

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
            Console.WriteLine();
            return total;

        }

        // public static double MakeDivisionForDecimals(double firstNumber, double secondNumber, double total)
        // {
        //     while (secondNumber == 0)
        //     {
        //         Console.WriteLine("Number mustn't be zero. Type another number, and then press Enter:");
        //         secondNumberInput = Console.ReadLine();

        //         while (!double.TryParse(secondNumberInput, out secondNumber))
        //         {
        //             Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
        //             secondNumberInput = Console.ReadLine();
        //         }
        //     }

        //     // rounds--;
        //     // counter++;

        //     total = firstNumber / secondNumber;
        //     double totalRounded = Math.Round(total, 2);

        //     // mathGame = string.Format($"{firstNumber} / {secondNumber} = {totalRounded}");
        //     // mathGames[counter] = mathGame;

        //     Console.WriteLine($"{firstNumber} / {secondNumber} = {totalRounded}");

        //     // correctAnswer++;
        //     // correctAnswerForDivision++;

        //     // scores[3, 1] = correctAnswerForDivision;
        //     Console.WriteLine();
        //     return total;

        // }

        // public void MakeDivisionForIntegers(double firstNumber, double secondNumber)
        // {
        //     while (secondNumber == 0)
        //     {
        //         Console.WriteLine("Number mustn't be zero. Type another number, and then press Enter:");
        //         secondNumberInput = Console.ReadLine();

        //         while (!double.TryParse(secondNumberInput, out secondNumber))
        //         {
        //             Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
        //             secondNumberInput = Console.ReadLine();
        //         }
        //     }

        //     rounds--;
        //     counter++;

        //     total = firstNumber / secondNumber;

        //     mathGame = string.Format($"{firstNumber} / {secondNumber} = {total}");
        //     mathGames[counter] = mathGame;

        //     Console.WriteLine($"{firstNumber} / {secondNumber} = {total}");

        //     correctAnswer++;
        //     correctAnswerForDivision++;

        //     scores[3, 1] = correctAnswerForDivision;
        //     Console.WriteLine();
        // }

        // public void MakeSquare(double firstNumber)
        // {
        //     rounds--;
        //     counter++;

        //     total = firstNumber * firstNumber;

        //     mathGame = string.Format($"{firstNumber} * {firstNumber} = {total}");
        //     mathGames[counter] = mathGame;

        //     Console.WriteLine($"{firstNumber} * {firstNumber} = {total}");
        //     correctAnswer++;
        //     correctAnswerForSquare++;

        //     scores[4, 1] = correctAnswerForSquare;
        //     Console.WriteLine();
        // }

        // public void evenOrOdd(double firstNumber)
        // {
        //     if (firstNumber % 2 == 0)
        //     {
        //         Console.WriteLine($"{firstNumber} is an even number");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{firstNumber} is an odd number");
        //     }
        // }

        // //public void DisplayLatestMathCalculations()
        // // {
        // //     string deleteBtn = "X";

        // //     for (int i = 0; i < mathGames.Length; i++)
        // //     {
        // //         if (mathGames[i] != null)
        // //         {
        // //             // Console.WriteLine(mathGames[i]);
        // //             Console.WriteLine();
        // //             Console.Write($"\t{mathGames[i]}");
        // //             Console.Write($"\t{deleteBtn}\n");
        // //         }
        // //         // Console.WriteLine(Console.ReadKey());
        // //     }
        // // }


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