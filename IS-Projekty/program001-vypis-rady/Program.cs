using System;

class Program {

    static void Main() {
        
        string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("**** Výpis číselné řady ****");
            Console.WriteLine("******* Tomáš Žižka ********");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();

            // Vstup od uživatele
            /* Console.Write("Zadejte první číslo (celé číslo): ");
            int first = int.Parse(Console.ReadLine()); */
            
            // Vstup od uživatele  - lépe řešený
            Console.Write("Zadejte první číslo (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
            }
            
            Console.Write("Zadejte poslední číslo (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo znovu: ");
            }

            Console.Write("Zadejte diferenci (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference: {0}", step);
            //Console.WriteLine("První číslo: {0}; poslední číslo: {1}", first, last);

            // Logika pro výpis řady
            int current = first;
            while(current <= last) {
                Console.WriteLine(current);
                current = current + step;
            } 

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }

        
        
        
        
    }
} 



