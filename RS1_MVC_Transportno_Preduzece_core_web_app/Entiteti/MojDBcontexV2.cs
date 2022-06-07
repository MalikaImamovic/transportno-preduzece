using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Entiteti
{
    public class MojDBcontexV2: DbContext
    {
            // konfiguracija tabela u bazi podataka svaka klasa treba imati svoj db set
            public DbSet<Zaposlenik> Zaposlenik { get; set; }
            public DbSet<RadniNalog> RadniNalog { get; set; }
            public DbSet<TipPrevoza> TipPrevoza { get; set; }
            public DbSet<PolaznaLokacija> PolaznaLokacija { get; set; }
            public DbSet<OdredisnaLokacija> OdredisnaLokacija { get; set; }
            public DbSet<Faktura> Faktura { get; set; }
            public DbSet<Skladiste> Skladiste { get; set; }
            public DbSet<Vozilo> Vozilo { get; set; }
            public DbSet<RadniNalog_Skladiste_Vozilo> RadniNalog_Skladiste_Vozilo { get; set; }
            public DbSet<PoslovniPartner> PoslovniPartner { get; set; }
            public DbSet<RadniNalog_PoslovniPartner> RadniNalog_PoslovniPartner { get; set; }
            public DbSet<Faktura_PoslovniPartner> Faktura_PoslovniPartner { get; set; }
            public DbSet<Racun> Racun { get; set; }
            public DbSet<Dostavnica> Dostavnica { get; set; }
            public DbSet<RadniNalog_Dostavnica_Racun> RadniNalog_Dostavnica_Racun { get; set; }
            public DbSet<Realizacija> Realizacija { get; set; }
            public DbSet<Racun_Realizacija> Racun_Realizacija { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"	Server=localhost;
                                        	Database=BrojIndeksa5;
                                            Trusted_Connection=true;
                                            MultipleActiveResultSets=true;");
            }
     }
}


