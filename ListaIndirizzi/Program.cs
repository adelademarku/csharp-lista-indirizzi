// See https://aka.ms/new-console-template for more information
//Oggi esercitazione sui file, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe,
//in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe,
//e salvare tutti gli indirizzi contenuti 
//al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
using ListaIndirizzi;

Console.WriteLine("Hello, World!");
List<Indirizzo> listaIndirizzi = new List<Indirizzo>();


try
{
    StreamReader file = File.OpenText("C:\\Users\\Generation\\OneDrive\\Desktop\\Nuova cartella (2)\\ListaIndirizzi\\ListaIndirizzi\\Nuova cartella\\addresses.csv");

    while (!file.EndOfStream)
    {
        string riga = file.ReadLine();


        string[] informazioniIndirizzo = riga.Split(",");

        string name = informazioniIndirizzo[0];
        string surname = informazioniIndirizzo[1];
        string street = informazioniIndirizzo[2];
        string city = informazioniIndirizzo[3];
        string province = informazioniIndirizzo[4];
        string zipcodes =informazioniIndirizzo[5];


        Indirizzo indirizzo = new Indirizzo(name,surname,street,city,province,zipcodes);
        listaIndirizzi.Add(indirizzo);
        // Console.WriteLine(riga);
    }

    file.Close();
}
catch (IndirizzoException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("c'è qualcosa che non va");
}


foreach (Indirizzo indirizzo in listaIndirizzi)
{
    Console.WriteLine(indirizzo);
}