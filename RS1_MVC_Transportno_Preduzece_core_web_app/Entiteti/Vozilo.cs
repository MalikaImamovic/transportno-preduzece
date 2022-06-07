using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Vozilo
    {
        public int VoziloID { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Nosivost { get; set; }
        public string Max_paleta { get; set; }
        public string Registracija { get; set; }
        public bool Raspolozivost { get; set; }
        public string Status_vozila { get; set; }
    }
}
