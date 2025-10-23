using System;

class FruitCollectie
{
    static void Main()
    {
       
        string[] fruit = { "appel", "banaan" };
        string[] groente = new string[3];
        int[] geluksgetallen = { 3, 7, 9 };
        int[] totTien = new int[10];
        bool[] antwoorden = { true, false, true };
        float[] temperaturen = { 18.5f, 20.1f, 22.3f };

        
        Console.WriteLine("Fruit: " + string.Join(", ", fruit));
        Console.WriteLine("Geluksgetallen: " + string.Join(", ", geluksgetallen));
    }
}

