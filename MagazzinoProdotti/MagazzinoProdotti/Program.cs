using System;
using MagazzinoProdotti.Entità;
using MagazzinoProdotti.DataLayer;

namespace MagazzinoProdotti
{
    class Program
    {
        static void Main(string[] args)
        {
            Prodotto[] productList = PruductFileManagement.GetAllProducts();
            decimal PrezzoTot = 0;
            int QuantitaOgetti = 0;
            string TutteDesc= "";
            foreach(Prodotto prodotto in productList)
            {
                Console.WriteLine(prodotto.Codice + " - " + prodotto.Descrizione + " - " + prodotto.Quantita + " - " + prodotto.PrezzoUnitario );
                PrezzoTot = PrezzoTot + prodotto.PrezzoUnitario;
                QuantitaOgetti = QuantitaOgetti + prodotto.Quantita;
                TutteDesc = TutteDesc + " " + prodotto.Descrizione;

            }
            Console.WriteLine("Prezzo totale carello: {0}", PrezzoTot);
            Console.WriteLine("Quantità dei prodotti in carello: {0}", QuantitaOgetti);
            Console.WriteLine("Tutte le descrizioni sono: {0}", TutteDesc);
            Console.WriteLine("Tutte le descrizioni sono: {0}", TutteDesc);
            Console.WriteLine("Tutte le descrizioni sono: {0}", TutteDesc);
        }
    }
}
