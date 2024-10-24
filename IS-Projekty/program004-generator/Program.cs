﻿using System.Security.Cryptography;

string again = "a";
while(again == "a") {

    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
    Console.WriteLine("*************** Tomáš Žižka *************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n)) {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while(!int.TryParse(Console.ReadLine(), out dm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while(!int.TryParse(Console.ReadLine(), out hm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
    Console.WriteLine("========================================================\n\n");
    
    // deklarace pole o velikosti n prvků
    int[] myArray = new int[n];

    // příprava pro generátor náhodných čísel
    Random randomNumber = new Random();

    int kladna = 0;
    int zaporna = 0;
    int nuly = 0;

    for(int i=0; i<n; i++) {
        myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("{0}; ", myArray[i]);

        // if(myArray[i] > 0)
        //     kladna++;
        // if(myArray[i] < 0)
        //     zaporna++;
        // if(myArray[i] == 0)
        //     nuly++;

        if(myArray[i] > 0)
           kladna++;
        else if(myArray[i] < 0)
           zaporna++;
        else
           nuly++;
    }    
    
    Console.WriteLine("\n\nPočet kladných čísel: {0}", kladna);
    Console.WriteLine("Počet záporných čísel: {0}", zaporna);
    Console.WriteLine("Počet nul: {0}", nuly);

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();    
}