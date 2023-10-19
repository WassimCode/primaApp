using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp2
{
    public class AutoInterattiva : testApp2.Auto
    {

        public int maxFuel {  get; private set; }
        public AutoInterattiva()
        {
            //super( marca,  modello,  colore,  tipoMotore,  fuel);
        }

        public AutoInterattiva(string marca, string modello, string colore, motori tipoMotore, int fuel, int chilometraggio, int maxFuel) : base(marca, modello, colore, tipoMotore, fuel, chilometraggio)
        {
            this.maxFuel = maxFuel;
        }

        public void menu()
        {
            // variabile di controllo
            int choice;

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
                Console.WriteLine("\n 7) Show speed.");
                Console.WriteLine("\n 8) Speed up.");
                Console.WriteLine("\n 9) Slow down.");
                Console.WriteLine("\n 0) Exit.");
                // converto la stringa di readline in intero
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    // Cambia il livello di carburante
                    case 1:
                        Console.Clear();

                        int newFuel = this.addCustomFuelLevel();
                        Console.Clear();

                        this.addFuelLevel(newFuel);
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

                    // Mostra la velocità corrente

                    case 7:
                        Console.Clear();

                        Console.WriteLine("\n Current speed: " + this.chilometraggio);
                        Console.WriteLine("\nPress enter to go back to the menu...");
                        Console.ReadLine();
                        break;
                     case 8:
                        Console.Clear();
                        if (this.isOn && (this.fuel > 0))
                        {
                            Console.WriteLine("By how many km/h do you want to accelerate?");
                            int speedUp = Int32.Parse(Console.ReadLine());
                            this.accelera(speedUp);
                        }
                        else
                            Console.WriteLine("Car engine is off, turn the car on first!");
                        Console.WriteLine("\nPress enter to go back to the menu...");

                        Console.ReadLine();

                        break;
                     case 9:
                        Console.Clear();
                        if (this.isOn)
                        {
                            Console.WriteLine("By how many km/h do you want to accelerate?");
                            int slowDown = Int32.Parse(Console.ReadLine());
                            this.rallenta(slowDown);
                        }
                        else
                            Console.WriteLine("Car engine is off, turn the car on first!");
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
            } while (choice != 0);
        }


    }
}
