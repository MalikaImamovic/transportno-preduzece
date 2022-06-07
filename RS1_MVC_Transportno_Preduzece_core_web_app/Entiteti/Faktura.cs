using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Faktura
    {
        public int FakturaID { get; set; }
        public string BrojPonude { get; set; }
        public string BrojFakture { get; set; }
        public string TipPonude { get; set; }
        public string JedinicaTereta { get; set; }
        public TipPrevoza TipPrevoza { get; set; }
        public string EksterniPrevoz { get; set; }
        public float Tezina { get; set; }
        public PolaznaLokacija PolaznaLokacija { get; set; }
        public OdredisnaLokacija OdredisnaLokacija { get; set; }
        public int Kilometraza { get; set; }
        public float Cijena { get; set; }
        public DateTime Datum { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
    }

}
