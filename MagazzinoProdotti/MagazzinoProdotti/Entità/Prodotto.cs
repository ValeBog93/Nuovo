using System;
using System.Collections.Generic;
using System.Text;

namespace MagazzinoProdotti.Entità
{
    public class Prodotto
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public int Quantita { get; set; }
        public decimal PrezzoUnitario { get; set; }
    }
}
