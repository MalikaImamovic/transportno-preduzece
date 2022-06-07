using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class Faktura_PoslovniPartner
    {
        public int Faktura_PoslovniPartnerID { get; set; }
        public Faktura Faktura { get; set; }
        public PoslovniPartner PoslovniPartner { get; set; }
        public string Napomena { get; set; }
    }
}
