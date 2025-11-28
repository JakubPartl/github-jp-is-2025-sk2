using System;
using System.Diagnostics;

        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("************* bubble sort ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Jakub Partl ******************");
            Console.WriteLine("************** 20.11.2025 ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Zadejte počet generovanách čísel (celé čísla): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovanách čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé čísla): ");
            int lowerBound;
            while (!int.TryParse(Console.ReadLine(), out lowerBound))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé čísla): ");
            int upperBound;
            while (!int.TryParse(Console.ReadLine(), out upperBound))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
            Console.WriteLine("********************************************");
            Console.WriteLine();

            int[] myRandNumbs = new int[n];
            Random myRandNum = new Random();

            Console.WriteLine();
            Console.WriteLine("Náhodná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myRandNumbs[i] = myRandNum.Next(lowerBound, upperBound);
                Console.Write("{0}; ", myRandNumbs[i]);
            }

            Stopwatch myStopwatch = new Stopwatch();
            int compare = 0;
            int change = 0;

            myStopwatch.Start();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    compare++;
                    if (myRandNumbs[j] < myRandNumbs[j + 1])
                    {
                        int tmp = myRandNumbs[j + 1];
                        myRandNumbs[j + 1] = myRandNumbs[j];
                        myRandNumbs[j] = tmp;
                        change++;
                    }
                }
            }
            myStopwatch.Stop();

            // =============================
            // Vypiš seřazené pole
            // =============================
            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("Seřazené pole: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}; ", myRandNumbs[i]);
            }
            Console.WriteLine();

            // =============================
            // Najdi druhé největší UNIKÁTNÍ číslo
            // =============================
            int max = myRandNumbs[0];
            int secmax = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                if (myRandNumbs[i] < max)
                {
                    secmax = myRandNumbs[i];
                    break;
                }
            }
            if (secmax == int.MinValue)
                Console.WriteLine("Druhé největší unikátní číslo neexistuje (všechna čísla jsou stejná).");
            else
                Console.WriteLine($"Druhé největší unikátní číslo: {secmax}");

            Console.WriteLine();
            Console.WriteLine($"Počet porovnání: {compare}");
            Console.WriteLine($"Počet výměn: {change}");
            Console.WriteLine();
            Console.WriteLine("Čas seřazení čísel pomocí BS: {0}", myStopwatch.Elapsed);

            if (secmax != int.MinValue)
{
    Console.WriteLine($"\nVykreslení obrazce s velikostí {secmax}:");

    // horní okraj - 2 řady
    for (int k = 0; k < 2; k++)
    {
        for (int i = 0; i < secmax; i++)
            Console.Write("*");
        Console.WriteLine();
    }

    // střední část - secmax - 4 řady (2 horní + 2 spodní)
    for (int i = 0; i < secmax - 4; i++)
    {
        Console.Write("*");
        for (int j = 0; j < secmax - 2; j++)
            Console.Write(" ");
        Console.WriteLine("*");
    }

    // spodní okraj - 2 řady
    for (int k = 0; k < 2; k++)
    {
        for (int i = 0; i < secmax; i++)
            Console.Write("*");
        Console.WriteLine();
    }
}

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
