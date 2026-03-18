using System;

class FitnessBoxingDemo
{
    static void Main()
    {
        Console.WriteLine("Fitness Tracker : Boxing and Unboxing Demo");

        int weight;
        Console.Write("Enter your body weight (kg): ");

        while (!int.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            Console.Write("Enter your body weight (kg): ");
        }

        object boxedWeight = weight;

        Console.WriteLine("\nAfter Boxing:");
        Console.WriteLine("Weight stored as object: " + boxedWeight);
        Console.WriteLine("Data type after boxing: " + boxedWeight.GetType());

        int unboxedWeight = (int)boxedWeight;

        Console.WriteLine("\nAfter Unboxing:");
        Console.WriteLine("Weight retrieved as integer: " + unboxedWeight);
        Console.WriteLine("Data type after unboxing: " + unboxedWeight.GetType());

        Console.WriteLine("\nFitness data processed successfully!");
    }
}