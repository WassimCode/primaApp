/*
 
App: Gestione Automobili

L'app deve modellare un'automibile per farlo deve registrare le informazioni relative a:
- marca
- modello
- colore
- tipo


*/
Auto a1 = new Auto();
a1.displayData();

Auto a2 = new Auto("Ford", "Mustang", "Red", Auto.motori.benzina);
a2.displayData();

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
    /// Costruttore
    /// </summary>
    public Auto()
    {
        this.marca = "";
        this.modello = "";
        this.colore = "";
        this.tipoMotore = motori.indefinito;
    }

    /// <summary>
    /// Crea il costruttore della classe Auto, quando crei l'oggetto
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



}
