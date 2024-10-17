string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("**** Výpis číselné řady ****");
            Console.WriteLine("******* Tomáš Žižka ********");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte číslo (celé číslo): ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte číslo (celé číslo): ");
            }
            
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Číslo: {0}", number);
            Console.WriteLine("========================================================");
            
            
           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }