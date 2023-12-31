﻿ using System;

namespace testApp2;
// new brnch
public class Auto
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
    /// proprietà del veicolo
    /// </summary>
    protected string marca;
    protected string modello;
    protected string colore;
    protected motori tipoMotore;
    protected const int maxFuelLevel = 100;
    public int chilometraggio { get; private set; }


    /// <summary>
    /// Verifica lo stato di accensione del veicolo
    /// </summary>
    public bool isOn;
    public int fuel { get; private set; }

    public int storedInAccountFuel = 0;


    #region " Constructors "
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
    public Auto(string marca, string modello, string colore, motori tipoMotore) : this(marca, modello, colore, tipoMotore, 0)
    {
        
    }
    /// <summary>
    /// Crea il costruttore, con parametri, della classe Auto
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="modello"></param>
    /// <param name="colore"></param>
    /// <param name="tipoMotore"></param>
    /// <param name="fuel"></param>
    public Auto(string marca, string modello, string colore, motori tipoMotore, int fuel)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
        this.fuel = fuel;
        this.isOn = false;
    }   
    
    /// <summary>
    /// Crea il costruttore, con parametri, della classe Auto
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="modello"></param>
    /// <param name="colore"></param>
    /// <param name="tipoMotore"></param>
    /// <param name="fuel"></param>
    public Auto(string marca, string modello, string colore, motori tipoMotore, int fuel, int chilometraggio)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
        this.fuel = fuel;
        this.chilometraggio = chilometraggio;
        this.isOn = false;
    }
    #endregion
    
    #region "display"

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

        result += "\nFuel: " + this.fuel;

        result += "\nSpeed : " + this.chilometraggio;

        result += "\nSaved in account fuel: " + this.storedInAccountFuel;


        if (this.isOn)
        {
            result += "\nTurned on.";
        }
        else
        {
            result += "\nTurned off";
        }

        return result;

    }


    public void showState()
    {

        string result = "";


        if (this.isOn)
        {
            result += "\nTurned on.";
        }
        else
        {
            result += "\nTurned off";
        }

        Console.WriteLine(result);
    }

    public string showStateOut()
    {

        string result = "";


        if (this.isOn)
        {
            result += "\nTurned on.";
        }
        else
        {
            result += "\nTurned off";
        }

        return result;
    }

    #endregion
    #region "azioni"
    /// <summary>
    /// Accende il veicolo, se il carburante è pari a 0, allora non lo accende
    /// </summary>
    public void turnOn()
    {
        if (this.fuel <= 0)
        {
            Console.WriteLine("\n Impossibile accendere il veicolo - Causa : livello carburante = 0");
            this.isOn = false;
        }
        else
        {
            if (this.isOn)
                Console.WriteLine("\nIl veicolo è già acceso!");
            else
            {
                // gli passa
                this.fuel--;
                Console.WriteLine("\nIl veicolo è partito con successo");
                this.isOn = true;

                if (this.fuel <= 0)
                {
                    Console.WriteLine("\n By turning on your veichle, you finished your only fuel left.\n The car now is off and the tank empty.");
                    this.isOn = false;
                }
            }


            
        }
    }

    /// <summary>
    /// Spegne il veicolo
    /// </summary>
    public void turnOff()
    {
        if (!this.isOn) { 
                Console.WriteLine("Il veicolo è già spento!");

                this.isOn = false;
            }

        else
        {
      
            if (this.chilometraggio == 0)
            {
                Console.WriteLine("Il veicolo è stato spento con successo!");
                this.isOn = false;
            }
            else
            {
                Console.WriteLine("\n You cannot turn off a car that's going! Stop and then turn off the car!");
            }
        }





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

        while (tempFuel < 0 || tempFuel > maxFuelLevel)
        {
            if (tempFuel < 0 || tempFuel > maxFuelLevel)
            {
                Console.WriteLine("\n Error, reinsert fuel level between 0 and " + maxFuelLevel +".");

            }
            Console.WriteLine("\n Insert the level of desired fuel: ");
            tempFuel = Convert.ToInt32(Console.ReadLine());

        }

        this.fuel = tempFuel;
        Console.WriteLine("\n Your new level is " + this.fuel);

        if (this.fuel == 0)
        {
            this.turnOff();
        }

    }    /// <summary>
    /// Aggiunta dinamica del livello di carburante, sommata a quella già presente
    /// </summary>
    public void addFuelLevel(int addedFuel)
    {
        if (addedFuel > 0)
        {
            this.fuel += addedFuel;
            if (this.fuel > maxFuelLevel)
            {
                this.storedInAccountFuel = returnPlusFuel(this.fuel);
                this.fuel = maxFuelLevel;
                Console.WriteLine("\n Tank filled completly!");
            }
            else
            {
                Console.WriteLine("\n The new level of fuel is " + this.fuel + ".");
            }
        }
       

    } 
    
    protected int addCustomFuelLevel()
    {
        int tempFuel;
        Console.WriteLine("\n Insert the level of desired added fuel: ");
        tempFuel = Convert.ToInt32(Console.ReadLine());

        while (tempFuel < 0 || tempFuel > maxFuelLevel)
        {
            if (tempFuel < 0 || tempFuel > maxFuelLevel)
            {
                Console.WriteLine("\n Error, reinsert fuel level between 0 and " + maxFuelLevel + ".");

            }
            Console.WriteLine("\n Insert the level of desired added fuel: ");
            tempFuel = Convert.ToInt32(Console.ReadLine());


        }

        return tempFuel;
    }
    
 
    private int returnPlusFuel(int insertedFuel)
    {
        return insertedFuel - maxFuelLevel;

    }
    /// <summary>
    ///  metodo che rallenta la velocità del veicolo, effettua anche i controlli del caso
    /// </summary>
    /// <param name="amount"></param>
    public void rallenta(int amount)
    {
      
            try
            {

                if (this.chilometraggio == 0)
                {
                    Console.WriteLine("\n Car is stopped, you cannot slow down further.");
                }
                else
                {
                    this.chilometraggio -= amount;
                    if (this.chilometraggio < 0)
                        this.chilometraggio = 0;

                    Console.WriteLine("\n Speed is now : " + this.chilometraggio + ".");
                }
            }
            catch (Exception e)
            {

            }
        }

    /// <summary>
    /// metoddo che aumenta la proprietà velocità della macchina di "amount" chilometri orari
    /// </summary>
    /// <param name="amount"></param>
    /// 
    /// 
    public void accelera(int amount)
    {
        //new branch

        // adds speed given by user to the current one
        this.chilometraggio = this.chilometraggio + amount;
        Console.WriteLine("Speed increased by " + amount + " km/h - current speed is now " + this.chilometraggio);

        // for issue #2 - consume fuel as much as the speed

        this.fuel -= amount;
        if (this.fuel <= 0)
        {
            this.fuel = 0;
            this.chilometraggio = 0;
            this.turnOff();
            Console.WriteLine("\n You finished you fuel tank! The car is now stopped and the engine is off!");
        }


        Console.ReadLine();
       

    }

    #endregion

}







