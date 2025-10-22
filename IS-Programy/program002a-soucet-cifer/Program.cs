string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********* Součet a součin cifer ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Partl ******************");
    Console.WriteLine("************** 16.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte první číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }

    int suma = 0;
    int soucin = 1;
    int numberBackup = number;
    int digit;

    //pokud je vstup záporný tak ho měníme na kladný
    if (number < 0)
    {
        number = -number;
    }


    if (number == 0)
    {
        suma = 0;
        soucin = 0;
    }
    else
    {
        while (number > 0)
        {
            digit = number % 10; //určí se nám zbytek
            number = number / 10;
            Console.WriteLine("Hodnota zbytku = {0}", digit);
            suma = suma + digit;
            soucin = soucin * digit;
        }
    }
        Console.WriteLine();
        Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
        Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, soucin);

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = (Console.ReadLine() ?? "").ToLower();
    }