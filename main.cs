using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the wind speed (in mph):");
        double windSpeed;
        if (double.TryParse(Console.ReadLine(), out windSpeed))
        {
            Console.WriteLine(GetHurricaneCategory(windSpeed));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid wind speed.");
        }
    }

    public static string GetHurricaneCategory(double windSpeed)
    {
        if (windSpeed < 74) return "Not a Hurricane";
        if (windSpeed >= 74 && windSpeed < 96) return "Category One Hurricane";
        if (windSpeed >= 96 && windSpeed < 111) return "Category Two Hurricane";
        if (windSpeed >= 111 && windSpeed < 130) return "Category Three Hurricane";
        if (windSpeed >= 130 && windSpeed < 157) return "Category Four Hurricane";
        return "Category Five Hurricane";
    }
}
