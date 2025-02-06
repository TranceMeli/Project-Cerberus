using cerberus_pass;

var pass1 = new PasswordEntry("P@ssword", "WaldmeisterSD", "P@ssword");
var pass2 = new PasswordEntry("P@ssword", "WaldmeisterSD", "P@ssword","https://store.steampowered.com", "Mein cooler Steam-Account");

//Console.WriteLine(pass1.Title.Length);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Willkommen zu Cerberus-Pass");
Console.WriteLine("Wähle was du tun willst");
Console.ResetColor();

System.Console.WriteLine("""
1. Password-Liste ausgeben
2. Password mit ID ausgeben
3. Neues Passwort erstellen
4. Vorhandenes Password bearbeiten
5. Password löschen
""");