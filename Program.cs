// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bitte geben sie ihren Vornamen ein: ");
string Vorname = Console.ReadLine();

Console.WriteLine("Bitte geben Sie ihren Nachnamen ein: ");
string Nachname = Console.ReadLine();

Console.WriteLine("Bitte geben Sie ihr Alter ein: ");
byte Alter = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Hallo " + Vorname + " " + Nachname + ". Sie sind " + Alter + " Jahre alt.");
Console.ReadKey();
    