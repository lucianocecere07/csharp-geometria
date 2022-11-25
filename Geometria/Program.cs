// See https://aka.ms/new-console-template for more information


using Geometria;

Rettangolo rettangoloUtente = new Rettangolo();

Console.Write("inserisci la base del rettangolo: ");
rettangoloUtente.baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("base: " + rettangoloUtente.baseRettangolo + " cm");

Console.Write("inserisci l'altezza del rettangolo: ");
rettangoloUtente.altezzaRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("altezza: " + rettangoloUtente.altezzaRettangolo + " cm");

int perimetroRettangoloUtente = rettangoloUtente.calcolaPerimetro();
Console.WriteLine("perimetro: " + perimetroRettangoloUtente + " cm");
int areaRettangoloUtente = rettangoloUtente.calcolaArea();
Console.WriteLine("area: " + areaRettangoloUtente + " cm^2");


