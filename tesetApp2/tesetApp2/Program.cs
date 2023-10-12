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


testApp2.Auto a3 = new testApp2.Auto("Ferrari", "LaFerrari", "Rossa", testApp2.Auto.motori.diesel, 20);

char choise = ' ';

while (choise != 'z') {
    Console.Clear();
    Console.WriteLine("Menu for "+ a3.marca + " " +  a3.modello +":\n");
    Console.WriteLine("\n a) Change fuel level.");
    Console.WriteLine("\n b) Turn on.");
    Console.WriteLine("\n c) Turn off.");
    Console.WriteLine("\n d) Show details.");
    Console.WriteLine("\n e) Show state.");
    Console.WriteLine("\n z) Exit.");
    choise = Convert.ToChar(Console.ReadLine());
    switch (choise)
    {
        case 'a':
            Console.Clear();
            a3.changeFuelLevel();
            break;        
        case 'b':
            Console.Clear();

            a3.turnOn();
            Console.WriteLine("\nPress enter to go back to the menu...");
            Console.ReadLine();
            break;        
        case 'c':
            Console.Clear();

            a3.turnOff();
            Console.WriteLine("\nPress enter to go back to the menu...");
            Console.ReadLine();
            break;        
        case 'd':
            Console.Clear();

            a3.displayData();
            Console.WriteLine("\nPress enter to go back to the menu...");
            Console.ReadLine();
            break;       
        case 'e':
            Console.Clear();

            a3.showState();
            Console.WriteLine("\nPress enter to go back to the menu...");
            Console.ReadLine();
            break;
        case 'z':
            Console.Clear();
            Console.WriteLine("\nClosed with success!");

            break;
        default:
            break;
    }
}



Console.ReadLine();





