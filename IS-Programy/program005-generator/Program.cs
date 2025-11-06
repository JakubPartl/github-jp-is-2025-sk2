string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel *******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Partl ******************");
    Console.WriteLine("************** 16.10.2025 ******************");
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
    int lowerBound; //Dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé čísla): ");
    int upperBound; //Horní mez
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

    //deklarace pole (array)
    int[] myRandNumbs = new int[n];

    // příprava pro využití třídy Random
    Random myRandNum = new Random();

//kladná, záporná, nebo nuly
    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    //sudá nebo lichá
    int evenNumbs = 0;
    int oddNumbs = 0;

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNum.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
        /* zbytečně dlouhý způsob
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        if (myRandNumbs[i] == 0)
            zeros++;
        */
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else if (myRandNumbs[i] < 0)
            negativeNumbs++;
        else zeros++; //nejmíň možné číslo, takže necháme na konci

        if (myRandNumbs[i] % 2 == 0) 
        evenNumbs++;
        else oddNumbs++;

    }

    Console.WriteLine();
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("Počet kladných: {0}", positiveNumbs);
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("Počet sudých: {0}", evenNumbs);
    Console.WriteLine("Počet lichých: {0}", oddNumbs);
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}