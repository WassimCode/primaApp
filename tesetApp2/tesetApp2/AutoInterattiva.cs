using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp2
{
    internal class AutoInterattiva : testApp2.Auto
    {
        public AutoInterattiva()
        {
            //super( marca,  modello,  colore,  tipoMotore,  fuel);
        }

        public AutoInterattiva(string marca, string modello, string colore, motori tipoMotore, int fuel) : base(marca, modello, colore, tipoMotore, fuel)
        {
            
        }

        public void menu()
        {
            // variabile di controllo
            int choise;

            // ciclo do while
            do
            {
                Console.Clear();
                Console.WriteLine("Menu for " + this.marca + " " + this.modello + ":\n_________________________\n");
                Console.WriteLine("\n 1) Change fuel level.");
                Console.WriteLine("\n 2) Turn on.");
                Console.WriteLine("\n 3) Turn off.");
                Console.WriteLine("\n 4) Show details.");
                Console.WriteLine("\n 5) Show state.");
                Console.WriteLine("\n 6) Add fuel.");
                Console.WriteLine("\n 7) Add custom fuel.");
                Console.WriteLine("\n 0) Exit.");
                // converto la stringa di readline in intero
                choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    // Cambia il livello di carburante
                    case 1:
                        Console.Clear();
                        this.changeFuelLevel();
                        break;
                    // Accendi il veicolo, dopo i dovuti controlli

                    case 2:
                        Console.Clear();

                        this.turnOn();
                        Console.WriteLine("\nPress enter to go back to the menu...");
                        Console.ReadLine();
                        break;
                    // Spegni il veicolo, dopo i dovuti controlli

                    case 3:
                        Console.Clear();

                        this.turnOff();
                        Console.WriteLine("\nPress enter to go back to the menu...");
                        Console.ReadLine();
                        break;
                    // Mostra i dettagli completi del veicolo

                    case 4:
                        Console.Clear();

                        this.displayData();
                        Console.WriteLine("\nPress enter to go back to the menu...");
                        Console.ReadLine();
                        break;

                    // Mostra lo stato di accensione del veicolo

                    case 5:
                        Console.Clear();

                        this.showState();
                        Console.WriteLine("\nPress enter to go back to the menu...");
                        Console.ReadLine();
                        break;     
                        
                        
                     // Aggiungi carburante al serbatoio(temporaneamente 10 fuel in maniera costante)

                    case 6:
                        Console.Clear();

                        this.addFuelLevel(10);
                        Console.WriteLine("\nPress enter to go back to the menu...");
                        Console.ReadLine();
                        break;

                    // Aggiungi carburante al serbatoio in maniera personalizzata

                    case 7:
                        Console.Clear();

                        int newFuel = this.addCustomFuelLevel();
                        Console.Clear();

                        this.addFuelLevel(newFuel);
                        Console.WriteLine("\nPress enter to go back to the menu...");
                        Console.ReadLine();
                        break;

                    // Uscita dal menu

                    case 0:
                        Console.Clear();
                        Console.WriteLine("\nClosed with success!");

                        break;
                    default:

                        Console.Clear();
                        break;
                }
            } while (choise != 0);
        }
    }
}
