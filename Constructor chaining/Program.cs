using System;

class Person
{
    string name;
    double weight;
    double height;

    public Person() : this("Ram")
    {
        Console.WriteLine("Default constructor called");
    }

    public Person(string personName) : this(personName, 60)
    {
        Console.WriteLine("Constructor with name called");
    }

    public Person(string personName, double bodyWeight)
        : this(personName, bodyWeight, 1.70)
    {
        Console.WriteLine("Constructor with name and weight called");
    }

    public Person(string personName, double bodyWeight, double bodyHeight)
    {
        name = personName;
        weight = bodyWeight;
        height = bodyHeight;

        Console.WriteLine("Final constructor executed");
    }

    public void DisplayBMI()
    {
        double bmi = weight / (height * height);

        Console.WriteLine("\nBMI Fitness Report");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Weight: " + weight + " kg");
        Console.WriteLine("Height: " + height + " m");
        Console.WriteLine("BMI: " + Math.Round(bmi, 2));
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Constructor Chaining Demonstration");

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        double weight;
        Console.Write("Enter weight (kg): ");
        while (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.Write("Invalid input! Enter weight again: ");
        }

        double height;
        Console.Write("Enter height (m): ");
        while (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.Write("Invalid input! Enter height again: ");
        }

        Person p = new Person(name, weight, height);
        p.DisplayBMI();
    }
}