using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Zaposlenik
    {
        public int ZaposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Pozicija { get; set; }
        public string Sektor { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; } 
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Broj_rjesenja { get; set; }
        public string Broj_transakcijskog_racuna { get; set; }
        public string Poslovna_banka { get; set; }
        public string Napomena { get; set; }
    }
}
