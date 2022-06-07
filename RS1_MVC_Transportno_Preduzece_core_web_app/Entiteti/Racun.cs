using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Racun
    {
        public int RacunID { get; set; }
        public string Brojracuna { get; set; }
        public string Opisne_stavke { get; set; }
        public float UkupnaCijena { get; set; }
        public float Porez { get; set; }
        public DateTime Datum_izdavanja { get; set; }
    }
}
