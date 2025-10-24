using System;

class Bruto
{
    static void Main()
    {
        double[] brutoSalarissen = { 2000.0, 3000.0, 4000.0 };
        double[] nettoSalarissen = new double[3];
        double belastingPercentage = 0.37;

        nettoSalarissen[0] = brutoSalarissen[0] * (1 - belastingPercentage);
        Console.WriteLine($"Bruto: {brutoSalarissen[0]}  →  Netto: {nettoSalarissen[0]:0.00}");

        nettoSalarissen[1] = brutoSalarissen[1] * (1 - belastingPercentage);
        Console.WriteLine($"Bruto: {brutoSalarissen[1]}  →  Netto: {nettoSalarissen[1]:0.00}");

        nettoSalarissen[2] = brutoSalarissen[2] * (1 - belastingPercentage);
        Console.WriteLine($"Bruto: {brutoSalarissen[2]}  →  Netto: {nettoSalarissen[2]:0.00}");
    }
}

