


string option1 = "Croissants";
double option1price = 1.50;
double preisBrezel = 1.00;
double preisBrot = 2.00;

double preis = 0.0;

bool incorrectSelection = true;
string auswahl = "";

while (incorrectSelection) {
    Console.WriteLine($"Was möchten Sie? Bitte wählen Sie zwischen: {option1}, Brezel, Brot");

    auswahl = Console.ReadLine();


    if (auswahl == option1)
    {
        incorrectSelection = false;
        preis = option1price;
        Console.WriteLine($"Sie haben {option1} gewählt.");
    }
    else if (auswahl == "Brezel")
    {
        preis = preisBrezel;
        Console.WriteLine("Sie haben Brezel gewählt.");
    }
    else if (auswahl == "Brot")
    {
        preis = preisBrot;
        Console.WriteLine("Sie haben Brot gewählt.");
    }
    else
    {
        Console.WriteLine("Ungültige Auswahl, bitte wählen Sie zwischen: Butterbrötchen, Brezel oder Brot.");
    }
}


Console.WriteLine("Wie viele " + auswahl + " möchten Sie kaufen? Geben Sie hier eine Zahl zwischen 1 und 10 ein:");
string input = Console.ReadLine();
int zahl;

if (int.TryParse(input, out zahl))
{
    if (zahl >= 1 && zahl <= 10)
    {
        double gesamtpreis = preis * zahl;
        Console.WriteLine("Sie haben " + zahl + " " + auswahl + "(n) gewählt.");
        Console.WriteLine("Der Gesamtpreis beträgt: " + gesamtpreis + " Euro.");
    }
    else
    {
        Console.WriteLine("Sie dürfen höchstens 10 Stück wählen.");
    }
}
else
{
    Console.WriteLine("Das ist keine gültige Zahl.");
}