using ProdottiEstesi;


Acqua lilia = new Acqua("lilia", "Acqua",7, 1, "Fonti Del Volture", 20, 2);


lilia.Bevi(1);
lilia.Riempi(-1);

double litri = lilia.getLitri();
Console.WriteLine("La bottiglia ha: " + litri + " litri");

lilia.NomeEsteso();

lilia.PrezzoSenzaIva();
double prezzo = lilia.GetPrezzo();
Console.WriteLine(prezzo);

