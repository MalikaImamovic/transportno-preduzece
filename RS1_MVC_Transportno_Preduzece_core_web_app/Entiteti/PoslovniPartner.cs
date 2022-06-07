using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class PoslovniPartner
    {
        public int PoslovniPartnerID { get; set; }
        public string TipPartnera { get; set; }
        public string Naziv { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string ID_PDV_broj { get; set; }
        public string Email { get; set; }
        public string Broj_PDV_rjesenja { get; set; }
        public string Broj_transakcijskog_racuna { get; set; }
        public string Poslovna_banka { get; set; }
        public string Detalji { get; set; }
        public int BrojRealizacija { get; set; }
    }
}
