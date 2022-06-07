using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_MVC_Transportno_Preduzece_core_web_app.Migrations
{
    public partial class InicijalnaDB_v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dostavnica",
                columns: table => new
                {
                    DostavnicaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojDostavnice = table.Column<string>(nullable: true),
                    Datum_realizacije = table.Column<DateTime>(nullable: false),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostavnica", x => x.DostavnicaID);
                });

            migrationBuilder.CreateTable(
                name: "OdredisnaLokacija",
                columns: table => new
                {
                    OdredisnaLokacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Udaljenost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdredisnaLokacija", x => x.OdredisnaLokacijaID);
                });

            migrationBuilder.CreateTable(
                name: "PolaznaLokacija",
                columns: table => new
                {
                    PolaznaLokacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolaznaLokacija", x => x.PolaznaLokacijaID);
                });

            migrationBuilder.CreateTable(
                name: "PoslovniPartner",
                columns: table => new
                {
                    PoslovniPartnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipPartnera = table.Column<string>(nullable: true),
                    Naziv = table.Column<string>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    ID_PDV_broj = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Broj_PDV_rjesenja = table.Column<string>(nullable: true),
                    Broj_transakcijskog_racuna = table.Column<string>(nullable: true),
                    Poslovna_banka = table.Column<string>(nullable: true),
                    Detalji = table.Column<string>(nullable: true),
                    BrojRealizacija = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoslovniPartner", x => x.PoslovniPartnerID);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brojracuna = table.Column<string>(nullable: true),
                    Opisne_stavke = table.Column<string>(nullable: true),
                    UkupnaCijena = table.Column<float>(nullable: false),
                    Porez = table.Column<float>(nullable: false),
                    Datum_izdavanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunID);
                });

            migrationBuilder.CreateTable(
                name: "Realizacija",
                columns: table => new
                {
                    RealizacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Metoda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realizacija", x => x.RealizacijaID);
                });

            migrationBuilder.CreateTable(
                name: "Skladiste",
                columns: table => new
                {
                    SkladisteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv_robe = table.Column<string>(nullable: true),
                    Kolicina_paleta = table.Column<int>(nullable: false),
                    Status_robe = table.Column<string>(nullable: true),
                    Datum_skladistenja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladiste", x => x.SkladisteID);
                });

            migrationBuilder.CreateTable(
                name: "TipPrevoza",
                columns: table => new
                {
                    TipPrevozaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipPrevoza", x => x.TipPrevozaID);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    VoziloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Vrsta = table.Column<string>(nullable: true),
                    Nosivost = table.Column<string>(nullable: true),
                    Max_paleta = table.Column<string>(nullable: true),
                    Registracija = table.Column<string>(nullable: true),
                    Raspolozivost = table.Column<bool>(nullable: false),
                    Status_vozila = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.VoziloID);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    ZaposlenikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    Pozicija = table.Column<string>(nullable: true),
                    Sektor = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Broj_rjesenja = table.Column<string>(nullable: true),
                    Broj_transakcijskog_racuna = table.Column<string>(nullable: true),
                    Poslovna_banka = table.Column<string>(nullable: true),
                    Napomena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.ZaposlenikID);
                });

            migrationBuilder.CreateTable(
                name: "Faktura",
                columns: table => new
                {
                    FakturaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojPonude = table.Column<string>(nullable: true),
                    BrojFakture = table.Column<string>(nullable: true),
                    TipPonude = table.Column<string>(nullable: true),
                    JedinicaTereta = table.Column<string>(nullable: true),
                    TipPrevozaID = table.Column<int>(nullable: true),
                    EksterniPrevoz = table.Column<string>(nullable: true),
                    Tezina = table.Column<float>(nullable: false),
                    PolaznaLokacijaID = table.Column<int>(nullable: true),
                    OdredisnaLokacijaID = table.Column<int>(nullable: true),
                    Kilometraza = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    ZaposlenikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktura", x => x.FakturaID);
                    table.ForeignKey(
                        name: "FK_Faktura_OdredisnaLokacija_OdredisnaLokacijaID",
                        column: x => x.OdredisnaLokacijaID,
                        principalTable: "OdredisnaLokacija",
                        principalColumn: "OdredisnaLokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faktura_PolaznaLokacija_PolaznaLokacijaID",
                        column: x => x.PolaznaLokacijaID,
                        principalTable: "PolaznaLokacija",
                        principalColumn: "PolaznaLokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faktura_TipPrevoza_TipPrevozaID",
                        column: x => x.TipPrevozaID,
                        principalTable: "TipPrevoza",
                        principalColumn: "TipPrevozaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faktura_Zaposlenik_ZaposlenikID",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenik",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racun_Realizacija",
                columns: table => new
                {
                    Racun_RealizacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealizacijaID = table.Column<int>(nullable: true),
                    RacunID = table.Column<int>(nullable: true),
                    ZaposlenikID = table.Column<int>(nullable: true),
                    PoslovniPartnerID = table.Column<int>(nullable: true),
                    Datum_realizacije = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun_Realizacija", x => x.Racun_RealizacijaID);
                    table.ForeignKey(
                        name: "FK_Racun_Realizacija_PoslovniPartner_PoslovniPartnerID",
                        column: x => x.PoslovniPartnerID,
                        principalTable: "PoslovniPartner",
                        principalColumn: "PoslovniPartnerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racun_Realizacija_Racun_RacunID",
                        column: x => x.RacunID,
                        principalTable: "Racun",
                        principalColumn: "RacunID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racun_Realizacija_Realizacija_RealizacijaID",
                        column: x => x.RealizacijaID,
                        principalTable: "Realizacija",
                        principalColumn: "RealizacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racun_Realizacija_Zaposlenik_ZaposlenikID",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenik",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RadniNalog",
                columns: table => new
                {
                    RadniNalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojPonude = table.Column<string>(nullable: true),
                    BrojRadnogNaloga = table.Column<string>(nullable: true),
                    JedinicaTereta = table.Column<string>(nullable: true),
                    TipPrevozaID = table.Column<int>(nullable: true),
                    EksterniPrevoz = table.Column<string>(nullable: true),
                    Tezina = table.Column<float>(nullable: false),
                    PolaznaLokacijaID = table.Column<int>(nullable: true),
                    OdredisnaLokacijaID = table.Column<int>(nullable: true),
                    Kilometraza = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    ZaposlenikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadniNalog", x => x.RadniNalogID);
                    table.ForeignKey(
                        name: "FK_RadniNalog_OdredisnaLokacija_OdredisnaLokacijaID",
                        column: x => x.OdredisnaLokacijaID,
                        principalTable: "OdredisnaLokacija",
                        principalColumn: "OdredisnaLokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_PolaznaLokacija_PolaznaLokacijaID",
                        column: x => x.PolaznaLokacijaID,
                        principalTable: "PolaznaLokacija",
                        principalColumn: "PolaznaLokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_TipPrevoza_TipPrevozaID",
                        column: x => x.TipPrevozaID,
                        principalTable: "TipPrevoza",
                        principalColumn: "TipPrevozaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Zaposlenik_ZaposlenikID",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenik",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faktura_PoslovniPartner",
                columns: table => new
                {
                    Faktura_PoslovniPartnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakturaID = table.Column<int>(nullable: true),
                    PoslovniPartnerID = table.Column<int>(nullable: true),
                    Napomena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktura_PoslovniPartner", x => x.Faktura_PoslovniPartnerID);
                    table.ForeignKey(
                        name: "FK_Faktura_PoslovniPartner_Faktura_FakturaID",
                        column: x => x.FakturaID,
                        principalTable: "Faktura",
                        principalColumn: "FakturaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faktura_PoslovniPartner_PoslovniPartner_PoslovniPartnerID",
                        column: x => x.PoslovniPartnerID,
                        principalTable: "PoslovniPartner",
                        principalColumn: "PoslovniPartnerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RadniNalog_Dostavnica_Racun",
                columns: table => new
                {
                    RadniNalog_Dostavnica_RacunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadniNalogID = table.Column<int>(nullable: true),
                    DostavnicaID = table.Column<int>(nullable: true),
                    RacunID = table.Column<int>(nullable: true),
                    Napomena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadniNalog_Dostavnica_Racun", x => x.RadniNalog_Dostavnica_RacunID);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Dostavnica_Racun_Dostavnica_DostavnicaID",
                        column: x => x.DostavnicaID,
                        principalTable: "Dostavnica",
                        principalColumn: "DostavnicaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Dostavnica_Racun_Racun_RacunID",
                        column: x => x.RacunID,
                        principalTable: "Racun",
                        principalColumn: "RacunID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Dostavnica_Racun_RadniNalog_RadniNalogID",
                        column: x => x.RadniNalogID,
                        principalTable: "RadniNalog",
                        principalColumn: "RadniNalogID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RadniNalog_PoslovniPartner",
                columns: table => new
                {
                    RadniNalog_PoslovniPartnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadniNalogID = table.Column<int>(nullable: true),
                    PoslovniPartnerID = table.Column<int>(nullable: true),
                    Napomena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadniNalog_PoslovniPartner", x => x.RadniNalog_PoslovniPartnerID);
                    table.ForeignKey(
                        name: "FK_RadniNalog_PoslovniPartner_PoslovniPartner_PoslovniPartnerID",
                        column: x => x.PoslovniPartnerID,
                        principalTable: "PoslovniPartner",
                        principalColumn: "PoslovniPartnerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_PoslovniPartner_RadniNalog_RadniNalogID",
                        column: x => x.RadniNalogID,
                        principalTable: "RadniNalog",
                        principalColumn: "RadniNalogID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RadniNalog_Skladiste_Vozilo",
                columns: table => new
                {
                    RadniNalog_Skladiste_VoziloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadniNalogID = table.Column<int>(nullable: true),
                    SkladisteID = table.Column<int>(nullable: true),
                    VoziloID = table.Column<int>(nullable: true),
                    ZaposlenikID = table.Column<int>(nullable: true),
                    Kolicina_paleta = table.Column<float>(nullable: false),
                    Datum_zaduzenja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadniNalog_Skladiste_Vozilo", x => x.RadniNalog_Skladiste_VoziloID);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Skladiste_Vozilo_RadniNalog_RadniNalogID",
                        column: x => x.RadniNalogID,
                        principalTable: "RadniNalog",
                        principalColumn: "RadniNalogID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Skladiste_Vozilo_Skladiste_SkladisteID",
                        column: x => x.SkladisteID,
                        principalTable: "Skladiste",
                        principalColumn: "SkladisteID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Skladiste_Vozilo_Vozilo_VoziloID",
                        column: x => x.VoziloID,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RadniNalog_Skladiste_Vozilo_Zaposlenik_ZaposlenikID",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenik",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_OdredisnaLokacijaID",
                table: "Faktura",
                column: "OdredisnaLokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_PolaznaLokacijaID",
                table: "Faktura",
                column: "PolaznaLokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_TipPrevozaID",
                table: "Faktura",
                column: "TipPrevozaID");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_ZaposlenikID",
                table: "Faktura",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_PoslovniPartner_FakturaID",
                table: "Faktura_PoslovniPartner",
                column: "FakturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_PoslovniPartner_PoslovniPartnerID",
                table: "Faktura_PoslovniPartner",
                column: "PoslovniPartnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Realizacija_PoslovniPartnerID",
                table: "Racun_Realizacija",
                column: "PoslovniPartnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Realizacija_RacunID",
                table: "Racun_Realizacija",
                column: "RacunID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Realizacija_RealizacijaID",
                table: "Racun_Realizacija",
                column: "RealizacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Realizacija_ZaposlenikID",
                table: "Racun_Realizacija",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_OdredisnaLokacijaID",
                table: "RadniNalog",
                column: "OdredisnaLokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_PolaznaLokacijaID",
                table: "RadniNalog",
                column: "PolaznaLokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_TipPrevozaID",
                table: "RadniNalog",
                column: "TipPrevozaID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_ZaposlenikID",
                table: "RadniNalog",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_Dostavnica_Racun_DostavnicaID",
                table: "RadniNalog_Dostavnica_Racun",
                column: "DostavnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_Dostavnica_Racun_RacunID",
                table: "RadniNalog_Dostavnica_Racun",
                column: "RacunID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_Dostavnica_Racun_RadniNalogID",
                table: "RadniNalog_Dostavnica_Racun",
                column: "RadniNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_PoslovniPartner_PoslovniPartnerID",
                table: "RadniNalog_PoslovniPartner",
                column: "PoslovniPartnerID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_PoslovniPartner_RadniNalogID",
                table: "RadniNalog_PoslovniPartner",
                column: "RadniNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_Skladiste_Vozilo_RadniNalogID",
                table: "RadniNalog_Skladiste_Vozilo",
                column: "RadniNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_Skladiste_Vozilo_SkladisteID",
                table: "RadniNalog_Skladiste_Vozilo",
                column: "SkladisteID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_Skladiste_Vozilo_VoziloID",
                table: "RadniNalog_Skladiste_Vozilo",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_Skladiste_Vozilo_ZaposlenikID",
                table: "RadniNalog_Skladiste_Vozilo",
                column: "ZaposlenikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faktura_PoslovniPartner");

            migrationBuilder.DropTable(
                name: "Racun_Realizacija");

            migrationBuilder.DropTable(
                name: "RadniNalog_Dostavnica_Racun");

            migrationBuilder.DropTable(
                name: "RadniNalog_PoslovniPartner");

            migrationBuilder.DropTable(
                name: "RadniNalog_Skladiste_Vozilo");

            migrationBuilder.DropTable(
                name: "Faktura");

            migrationBuilder.DropTable(
                name: "Realizacija");

            migrationBuilder.DropTable(
                name: "Dostavnica");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "PoslovniPartner");

            migrationBuilder.DropTable(
                name: "RadniNalog");

            migrationBuilder.DropTable(
                name: "Skladiste");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "OdredisnaLokacija");

            migrationBuilder.DropTable(
                name: "PolaznaLokacija");

            migrationBuilder.DropTable(
                name: "TipPrevoza");

            migrationBuilder.DropTable(
                name: "Zaposlenik");
        }
    }
}
