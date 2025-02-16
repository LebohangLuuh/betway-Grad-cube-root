using System;

class Program
{
    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out int power))
        {
            Console.WriteLine(IsMagicalPotion(power) ? "YES" : "NO");
        }
    }

    static bool IsMagicalPotion(int power)
    {
        if (power < 1) return false;
        
        int cubeRoot = (int)Math.Round(Math.Pow(power, 1.0 / 3.0));
        return cubeRoot * cubeRoot * cubeRoot == power;
    }
}