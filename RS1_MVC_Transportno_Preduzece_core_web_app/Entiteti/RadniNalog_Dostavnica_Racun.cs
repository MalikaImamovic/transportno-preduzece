using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class RadniNalog_Dostavnica_Racun
    {
        public int RadniNalog_Dostavnica_RacunID { get; set; }
        public RadniNalog RadniNalog { get; set; }
        public Dostavnica Dostavnica { get; set; }
        public Racun Racun { get; set; }
        public string Napomena { get; set; }
    }
}
