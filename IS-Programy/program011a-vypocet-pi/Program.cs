string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Konvergentní řada **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jakub Partl ******************");
    Console.WriteLine("************** 4.12.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte přesnost pro výpočet pi (reálné číslo - čím menší hodnota, tím bude výpočet přesnější): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste realné číslo. Zadejte přesnost pro výpočet pi znovu: ");
    }

    double i = 1;
    double znamenko = 1;
    double piCtvrt = 1;

    while((1/i)>=presnost) {
        i = i + 2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * (1/i);

        if(znamenko==1) {
            Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);
        }
        else {
            Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);
        }

    Console.WriteLine("\n\n Hodnota čísla PI = {0}", 4 * piCtvrt);
    //Console.WriteLine("\n\n Hodnota čísla PI = {0:f4}", 4 * piCtvrt);

    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}