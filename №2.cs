using System;
using System.Collections.Generic;
using System.Linq;

class Laba02
{
    static void Main2()
    {
        Random rand = new Random();
        int N = 10; // Кількість чисел у колекції
        List<int> numbers = new List<int>();

        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(15, 56));
        }

        Console.WriteLine("Оригінальна колекція:");
        numbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine();

        // Знайти перше число кратне 3 або 5 і видалити його
        int indexToRemove = numbers.FindIndex(n => n % 3 == 0 || n % 5 == 0);
        if (indexToRemove != -1)
        {
            numbers.RemoveAt(indexToRemove);
        }

        Console.WriteLine("Колекція після видалення:");
        numbers.ForEach(n => Console.Write(n + " "));
    }
}
