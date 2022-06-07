using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Dostavnica
    {
        public int DostavnicaID { get; set; }
        public string BrojDostavnice { get; set; }
        public DateTime Datum_realizacije { get; set; }
        public string Opis { get; set; }
    }
}
