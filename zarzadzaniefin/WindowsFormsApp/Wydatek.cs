using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal class Wydatek
    {
        public string Nazwa { get; set; }
       public decimal Kwota { get; set; }
        public string Kategoria { get; set; }
        public Wydatek(string nazwa, decimal kwota, string kategoria)
        {
            Nazwa = nazwa;
            Kwota = kwota;
            Kategoria = kategoria;
        }
    }
}
