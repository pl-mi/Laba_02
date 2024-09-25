using System;
using System.Collections.Generic;
using System.Linq;

class Laba_02
{
    static void Main3()
    {
        Random rand = new Random();
        int N = 10; // Кількість чисел у колекції
        List<int> numbers = new List<int>();

        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(10, 100));
        }

        Console.WriteLine("Оригінальна колекція:");
        numbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine();

        List<int> multiplesOfThree = numbers.Where(n => n % 3 == 0).ToList();
        List<int> nonMultiplesOfThree = numbers.Where(n => n % 3 != 0).ToList();

        Console.WriteLine("Числа кратні 3:");
        multiplesOfThree.ForEach(n => Console.Write(n + " "));
        Console.WriteLine();

        Console.WriteLine("Інші числа:");
        nonMultiplesOfThree.ForEach(n => Console.Write(n + " "));
    }
}
