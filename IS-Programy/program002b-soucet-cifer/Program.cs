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

    Console.Write("Zadejte číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }

    int numberBackup = number;
    string numberStr = Math.Abs(number).ToString(); // absolutní hodnota pro záporná čísla
    int suma = 0;
    int soucin = numberStr.Length > 0 ? 1 : 0; // pokud je nula, součin bude 0

    Console.WriteLine();
    foreach (char c in numberStr)
    {
        int digit = c - '0'; // převedeme znak na číslo
        Console.WriteLine("Hodnota zbytku = {0}", digit);
        suma += digit;
        soucin *= digit;
    }

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
    Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, soucin);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = (Console.ReadLine() ?? "").Trim().ToLower();
}

