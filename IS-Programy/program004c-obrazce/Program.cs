string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Vykreslování ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Jakub Partl 2025 **************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte velikost obrazců: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n < 3)
    {
        Console.Write("Zadejte celé číslo (min 3): ");
    }

    Console.WriteLine();
    Console.WriteLine("*********** Obrazec 1: Čtverec *************");
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write("* ");
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("*********** Obrazec 2: Z - Tvar ************");
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == 0) Console.Write("* ");               // horní řada
            else if (i == n - 1) Console.Write("* ");      // dolní řada
            else if (j == n - 1 - i) Console.Write("* ");  // diagonála zprava dolů
            else Console.Write("  ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("********* Obrazec 3: Kosočtverec ***********");
    Console.WriteLine();

    int mid = n / 2;
    for (int i = 0; i < n; i++)
    {
        int distance = Math.Abs(mid - i);

        for (int j = 0; j < distance; j++)
            Console.Write(" ");

        Console.Write("*");

        int inner = n - 2 * distance - 2;
        if (inner >= 0)
        {
            for (int j = 0; j < inner; j++)
                Console.Write(" ");
            Console.Write("*");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}