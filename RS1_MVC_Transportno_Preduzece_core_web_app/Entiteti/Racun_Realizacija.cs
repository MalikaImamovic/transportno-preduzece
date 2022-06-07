using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Racun_Realizacija
    {
        public int Racun_RealizacijaID { get; set; }
        public Realizacija Realizacija { get; set; }
        public Racun Racun { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public PoslovniPartner PoslovniPartner { get; set; }
        public  DateTime Datum_realizacije { get; set; }
    }
}
