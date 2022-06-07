using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class RadniNalog_Skladiste_Vozilo
    {
        public int RadniNalog_Skladiste_VoziloID { get; set; }
        public RadniNalog RadniNalog { get; set; }
        public Skladiste Skladiste { get; set; }
        public Vozilo Vozilo { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public float Kolicina_paleta { get; set; }
        public DateTime Datum_zaduzenja { get; set; }
    }
}
