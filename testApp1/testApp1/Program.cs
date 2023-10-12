/*
 
App: Gestione Automobili

L'app deve modellare un'automibile per farlo deve registrare le informazioni relative a:
- marca
- modello
- colore
*/


Auto a1 = new Auto();
a1.displayData();

Auto a2 = new Auto("Ford", "Mustang", "Red", Auto.motori.benzina);
a2.displayData();

Console.ReadLine();


class Auto{
    // Tipi personlizzati
    public enum motori
    {
        benzina,
        diesel,
        elettrico,
        indefinito
    }

    //  Proprietà
    public string marca;
    public string modello;
    public string colore;
    public motori tipoMotore;

    public Auto() {
        this.marca = "";
        this.modello= "";
        this.colore = "";
        this.tipoMotore = motori.indefinito;
    }

    public Auto(string marca, string modello, string colore,  motori tipoMotore) {
        this.marca = marca;
        this.modello= modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
    }

    public void displayData()
    {
        Console.WriteLine("Marca : " + this.marca);
        Console.WriteLine("modello : " + this.modello);
        Console.WriteLine("colore :" + this.colore);
        Console.WriteLine("tipoMotore: "+  this.tipoMotore);
        Console.WriteLine("\n-------------------\n");

    }

    /*
     * 
    public void displayData()
    {
        generaData();    
    }
     
    public string generaData(){
        
        string result = "";

        result += "\nMarca : " + this.marca;
        
        result += "\nmodello : " + this.modello;
        
        result += "\ncolore :" + this.colore;
      
        result += "\ntipoMotore: "+  this.tipoMotore;

        return result;
    
    }
     */


}
