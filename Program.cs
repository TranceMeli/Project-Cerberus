using System.Buffers;
using cerberus_pass;

var pass1 = new PasswordEntry("P@ssword", "WaldmeisterSD", "P@ssword");
var pass2 = new PasswordEntry("P@ssword", "WaldmeisterSD", "P@ssword","https://store.steampowered.com", "Mein cooler Steam-Account");

//Console.WriteLine(pass1.Title.Length);

var manager = new PasswordManager();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Willkommen zu Cerberus-Pass");
Console.WriteLine("Wähle was du tun willst");
Console.ResetColor();

do {
    System.Console.WriteLine("""
    1. Password-Liste ausgeben
    2. Password mit ID ausgeben
    3. Neues Passwort erstellen
    4. Vorhandenes Password bearbeiten
    5. Password löschen
    """);

    var userInput = Console.ReadLine();

    switch(userInput)
    {
        case "1":
        // Liste ausgeben
        var vault = manager.GetAll();
        System.Console.WriteLine(vault);
        break;
        case "2":
        // Password anhand ID auswählen
        break;
        case "3":
        Console.WriteLine("Gebe einen Titel für den Eintrag an:");
        var title = Console.ReadLine();
        System.Console.WriteLine("Gebe einen Login für den Eintrag ein");
        var login = Console.ReadLine();
        System.Console.WriteLine("Gebe ein Passwort für den Eintrag an");
        var password = Console.ReadLine();
        var newEntry = manager.CreateEntry(title, login, password);
        Console.WriteLine("Neuer Eintrag erfolgreich");
        Console.WriteLine(newEntry);
        // Erstellen
        break;
        case "4":
        // Update
        break;
        case "5":
        // Delete
        break;
        default:
        // Fehler anzeigen -> Eingabe-Hint (1-5)
        // Eingabe wiederholen
        break;
    }
    Console.ReadKey();
    Console.Clear();

}while(true);

//Console.WriteLine("Programmende");