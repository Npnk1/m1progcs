using System;

class VarIndex
{
    static void Main()
    {
        
        string[] namen = { "mario", "sonic", "spyro" };

        
        Console.WriteLine("Spelkarakters:");
        for (int i = 0; i < namen.Length; i++)
        {
            Console.WriteLine($"{i}: {namen[i]}");
        }

        
        Console.Write("\nKies een karakter (typ het indexnummer): ");
        string keuze = Console.ReadLine();

        
        int gekozenIndex = Convert.ToInt32(keuze);

        string gekozenNaam = namen[gekozenIndex];

        Console.WriteLine($"\nJe hebt gekozen: {gekozenNaam}");
    }
}
