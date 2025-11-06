string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("******** Pravoúhlý trojúhhelník ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Partl ******************");
    Console.WriteLine("************** 16.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

   Console.Write("Zadejte výšku trojúhelníku: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku trojúhelníku znovu: ");
    }

    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}