using System.ComponentModel;

string again = "a";
while(again == "a") {
    Console.Clear();
    razitko();

    ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
    ulong b = ziskatCislo("Zadejte přirozené číslo b: ");
    
    ulong nsd = vypocitatNsd(a, b);
    ulong nsn = vypocitatNns(a, b, nsd);
    
    zobrazitVysledky(a, b, nsd, nsn);
    
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();    

}

static void razitko() {
    Console.WriteLine("****************************");
    Console.WriteLine("**** Výpis číselné řady ****");
    Console.WriteLine("******* Tomáš Žižka ********");
    Console.WriteLine("****************************");
    Console.WriteLine();
    Console.WriteLine();
}

static ulong ziskatCislo(string zprava) {
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste přirozené číslo. Zadejte znovu: ");
    }
    
    return cislo;
}

static ulong vypocitatNsd(ulong a, ulong b) {
    while(a!=b) {
        if(a>b)
            a = a - b;
        else
            b = b - a;    
    }
    return a;
}

static ulong vypocitatNns(ulong a, ulong b, ulong nsd) {
    return (a*b)/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"NSN čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;
}
