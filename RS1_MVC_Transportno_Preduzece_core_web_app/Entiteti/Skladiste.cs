using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Skladiste
    {
        public int SkladisteID { get; set; }
        public string Naziv_robe { get; set; }
        public int Kolicina_paleta { get; set; }
        public string Status_robe { get; set; }
        public DateTime Datum_skladistenja{ get; set; }
    }
}
