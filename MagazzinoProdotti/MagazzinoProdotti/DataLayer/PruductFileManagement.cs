using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MagazzinoProdotti.Entità;

namespace MagazzinoProdotti.DataLayer
{
    public class PruductFileManagement
    {
        public static string path { get; } = "C:\\Users\\faggi\\OneDrive\\Desktop\\Prova\\Prodotti.csv";
        // Recupera lista prodotti
        public static Prodotto[] GetAllProducts()
        {
            int totalLines = File.ReadLines(path).Count();
            Prodotto[] productList = new Prodotto[totalLines - 1];
            string line;
            using (StreamReader reader = File.OpenText(path))
            {
                string header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    for (int i = 0; i < totalLines - 1; i++)
                    {
                        line = reader.ReadLine();
                        string[] productData = line.Split(";");

                        Prodotto product = new Prodotto
                        {
                            Codice = productData[0],
                            Descrizione = productData[1],
                            Quantita = Convert.ToInt32(productData[2]),
                            PrezzoUnitario = Convert.ToDecimal(productData[3])
                        };

                        productList[i] = product;

                    }
                }
                return productList;
            }
        }
    }
}
