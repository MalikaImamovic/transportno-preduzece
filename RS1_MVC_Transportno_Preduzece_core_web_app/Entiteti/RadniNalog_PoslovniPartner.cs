using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class RadniNalog_PoslovniPartner
    {
        public int RadniNalog_PoslovniPartnerID { get; set; }
        public RadniNalog RadniNalog { get; set; }
        public PoslovniPartner PoslovniPartner { get; set; }
        public string Napomena { get; set; }
    }
}
