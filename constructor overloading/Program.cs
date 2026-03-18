using System;
class Person
{
    string personName;
    double bodyWeight;
    double bodyHeight;

    public Person()
    {
        personName = "Rahul";
        bodyWeight = 60;
        bodyHeight = 1.70;
        Console.WriteLine("\nDefault constructor executed (profile created)");
    }

    public Person(string name)
    {
        personName = name;
        bodyWeight = 50;
        bodyHeight = 1.70;
        Console.WriteLine("\nConstructor with name executed");
    }

    public Person(string name, double weight, double height)
    {
        personName = name;
        bodyWeight = weight;
        bodyHeight = height;
        Console.WriteLine("\nConstructor with full fitness data executed");
    }

    public void ShowBMIReport()
    {
        double bmiScore = bodyWeight / (bodyHeight * bodyHeight);

        Console.WriteLine("\nPersonal Fitness Report");
        Console.WriteLine("Name : " + personName);
        Console.WriteLine("Weight : " + bodyWeight + " kg");
        Console.WriteLine("Height : " + bodyHeight + " m");
        Console.WriteLine("BMI Score : " + Math.Round(bmiScore, 2));

        if (bmiScore < 18.5)
        {
            Console.WriteLine("Health Status : Underweight");
            Console.WriteLine("Suggestion : Increase healthy calories and do strength training.");
        }
        else if (bmiScore < 25)
        {
            Console.WriteLine("Health Status : Normal / Fit");
            Console.WriteLine("Suggestion : Maintain balanced diet and regular exercise.");
        }
        else if (bmiScore < 30)
        {
            Console.WriteLine("Health Status : Overweight");
            Console.WriteLine("Suggestion : Add more cardio workouts and control sugar intake.");
        }
        else
        {
            Console.WriteLine("Health Status : Obese");
            Console.WriteLine("Suggestion : Consult a trainer and follow structured fitness plan.");
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Smart BMI Wellness Tracker");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        double weight;
        Console.Write("Enter your weight (kg): ");
        while (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.Write("Invalid input! Enter weight again: ");
        }

        double height;
        Console.Write("Enter your height (m): ");
        while (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.Write("Invalid input! Enter height again: ");
        }

        Person user = new Person(name, weight, height);
        user.ShowBMIReport();
    }
}