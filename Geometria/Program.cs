// See https://aka.ms/new-console-template for more information

/*
Nel progetto csharp-geometria creare le seguenti classi :
1. Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. 
Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono rispettivamente,
l’area e il perimetro del rettangolo.
2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire da console,
i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato,
occupatevi di configurare le sue proprietà di base e altezza  e stampate a video il perimetro e l’area.
3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo)
e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo
ad esempio cosi:
—— Rettangolo1 ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2
 */



using Geometria;

//creare nuovo rettangolo
Rettangolo rettangoloUtente = new Rettangolo();

//altri rettangoli
Rettangolo rettangoloDue = new Rettangolo();
Rettangolo rettangoloTre = new Rettangolo();
Rettangolo rettangoloQuattro = new Rettangolo();

//proprietà chieste all'utente (rettangolo uno)
Console.Write("inserisci la base del rettangolo uno: ");
rettangoloUtente.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("inserisci l'altezza del rettangolo uno: ");
rettangoloUtente.altezzaRettangolo = int.Parse(Console.ReadLine());

//rettangolo due
Console.Write("inserisci la base del rettangolo due: ");
rettangoloDue.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("inserisci l'altezza del rettangolo due: ");
rettangoloDue.altezzaRettangolo = int.Parse(Console.ReadLine());

//rettangolo tre
Console.Write("inserisci la base del rettangolo tre: ");
rettangoloTre.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("inserisci l'altezza del rettangolo tre: ");
rettangoloTre.altezzaRettangolo = int.Parse(Console.ReadLine());

//rettangolo quattro
Console.Write("inserisci la base del rettangolo quattro: ");
rettangoloQuattro.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("inserisci l'altezza del rettangolo quattro: ");
rettangoloQuattro.altezzaRettangolo = int.Parse(Console.ReadLine());

//metodo stampa rettangolo su console (PARTE 3)
Console.WriteLine("--- Rettangolo 1 ---");
rettangoloUtente.StampaRettangolo();

Console.WriteLine("--- Rettangolo 2 ---");
rettangoloDue.StampaRettangolo();

Console.WriteLine("--- Rettangolo 3 ---");
rettangoloTre.StampaRettangolo();

Console.WriteLine("--- Rettangolo 4 ---");
rettangoloQuattro.StampaRettangolo();


/* 
//stampa rettangolo uno su console (PARTE 2) -> come metodo StampaRettangolo
Console.WriteLine("base: " + rettangoloUtente.baseRettangolo + " cm");
Console.WriteLine("altezza: " + rettangoloUtente.altezzaRettangolo + " cm");
int perimetroRettangoloUtente = rettangoloUtente.CalcolaPerimetro();
Console.WriteLine("perimetro: " + perimetroRettangoloUtente + " cm");
int areaRettangoloUtente = rettangoloUtente.CalcolaArea();
Console.WriteLine("area: " + areaRettangoloUtente + " cm^2");
*/

