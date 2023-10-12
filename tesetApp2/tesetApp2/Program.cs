/*
 
App: Gestione Automobili

L'app deve modellare un'automibile per farlo deve registrare le informazioni relative a:
- marca
- modello
- colore
- tipo



Auto a1 = new Auto();
a1.displayData();

Auto a2 = new Auto("Ford", "Mustang", "Red", Auto.motori.benzina);
a2.displayData();

*/

Auto a3 = new Auto("Ferrari", "LaFerrari", "Rossa", Auto.motori.diesel, 20);

a3.turnOn();
char choise = ' ';

while (choise != 'z') {
    Console.WriteLine("Select the next action:");
    Console.WriteLine("\n a) Change fuel level.");
    Console.WriteLine("\n b) Turn on.");
    Console.WriteLine("\n c) Turn off.");
    Console.WriteLine("\n z) Exit.");
    choise = Convert.ToChar(Console.ReadLine());
    switch (choise)
    {
        case 'a':
            a3.changeFuelLevel();
            break;        
        case 'b':
            a3.turnOn();
            break;        
        case 'c':
            a3.turnOff();
            break;
        default:
            break;
    }
}



Console.ReadLine();




class Auto
{
    // Tipi personlizzati
    public enum motori
    {
        benzina,
        diesel,
        elettrico,
        indefinito
    }

    //  Proprietà

    /// <summary>
    /// marca del veicolo
    /// </summary>
    public string marca;
    public string modello;
    public string colore;
    public motori tipoMotore;

    /// <summary>
    /// Verifica lo stato di accensione del veicolo
    /// </summary>
    public bool isOn;
    public int fuel;

    /// <summary>
    /// Crea il costruttore
    /// </summary>
    public Auto()
    {
        this.marca = "";
        this.modello = "";
        this.colore = "";
        this.tipoMotore = motori.indefinito;
    }

    /// <summary>
    // /Crea il costruttore, con parametri, della classe Auto
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="modello"></param>
    /// <param name="colore"></param>
    /// <param name="tipoMotore"></param>
    public Auto(string marca, string modello, string colore, motori tipoMotore)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
    }
    /// <summary>
    /// Crea il costruttore, con parametri, della classe Auto
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="modello"></param>
    /// <param name="colore"></param>
    /// <param name="tipoMotore"></param>
    /// <param name="fuel"></param>
    public Auto(string marca, string modello, string colore, motori tipoMotore,  int fuel)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
        this.fuel = fuel;
        this.isOn = false; 
    }



    public void displayData()
    {
        Console.WriteLine(generaData());

    }


    public string generaData()
    {

        string result = "";

        result += "\nMarca : " + this.marca;

        result += "\nmodello : " + this.modello;

        result += "\ncolore :" + this.colore;

        result += "\ntipoMotore: " + this.tipoMotore;

        return result;

    }

    /// <summary>
    /// Accende il veicolo, se il carburante è pari a 0, allora non lo accende
    /// </summary>
    public void turnOn()
    {
        if (this.fuel == 0) {
            Console.WriteLine("\n Impossibile accendere il veicolo - Causa : livello carburante = 0");
            this.isOn = false;
        }
        else
        {
            if (this.isOn)
                Console.WriteLine("\nIl veicolo è già acceso!");
            else
                Console.WriteLine("\nIl veicolo è partito con successo");

            this.isOn = true;
        }
    }  
    
    /// <summary>
    /// Spegne il veicolo
    /// </summary>
    public void turnOff()
    {

        if (!this.isOn)
            Console.WriteLine("Il veicolo è già spento!");
        else
            Console.WriteLine("Il veicolo è stato spento con successo!");

        this.isOn = false;




    }
    /// <summary>
    /// A scelta dell'utente, cambia il livello di carbuante nel veicolo
    /// Controlli sulla integrita dei dati
    /// </summary>
    public void changeFuelLevel()
    {
        int tempFuel;
        Console.WriteLine("\n Insert the level of desired fuel: ");
        tempFuel = Convert.ToInt32(Console.ReadLine());
        
        while (tempFuel < 0 || tempFuel > 100)
        {
            if (tempFuel < 0 || tempFuel > 100)
            {
                Console.WriteLine("\n Error, reinsert fuel level between 0 and 100.");

            }
            Console.WriteLine("\n Insert the level of desired fuel: ");
            tempFuel = Convert.ToInt32(Console.ReadLine());

        }
        
        this.fuel = tempFuel;
        Console.WriteLine("\n Your new level is " + this.fuel);

    }


}
