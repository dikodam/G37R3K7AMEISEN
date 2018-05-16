using System.Collections.Generic;
using AntMe.Deutsch;

namespace AntMe.Player.g37r3k7ameisen
{
    [Spieler(Nachname = "Konieczny",
            Vorname = "Adam",
            Volkname = "G37R3K7"
        )
    ]
    [Kaste(Name = "Standard",
        AngriffModifikator = 0,
        DrehgeschwindigkeitModifikator = 0,
        EnergieModifikator = 0,
        GeschwindigkeitModifikator = 0,
        LastModifikator = 0,
        ReichweiteModifikator = 0,
        SichtweiteModifikator = 0)]
    public class Ameise : Basisameise
    {
        private IVerhalten verhalten;

        public override string BestimmeKaste(Dictionary<string, int> anzahl)
        {
            string kaste = "Standard";
            verhalten = new StandardVerhalten();
            return kaste;
        }

        public override void IstGestorben(Todesart todesart)
        {
            verhalten.IstGestorben(todesart);
        }

        public override void RiechtFreund(Markierung markierung)
        {
            verhalten.RiechtFreund(markierung);
        }

        public override void Sieht(Obst obst)
        {
            verhalten.Sieht(obst);
        }

        public override void Sieht(Zucker zucker)
        {
            verhalten.Sieht(zucker);
        }

        public override void SiehtFeind(AntMe.Deutsch.Ameise ameise)
        {
            verhalten.SiehtFeind(ameise);
        }

        public override void SiehtFeind(Wanze wanze)
        {
            verhalten.SiehtFeind(wanze);
        }

        public override void SiehtFreund(AntMe.Deutsch.Ameise ameise)
        {
            verhalten.SiehtFreund(ameise);
        }

        public override void SiehtVerbündeten(AntMe.Deutsch.Ameise ameise)
        {
            verhalten.SiehtVerbündeten(ameise);
        }

        public override void Tick()
        {
            verhalten.Tick();
        }

        public override void Wartet()
        {
            verhalten.Wartet();
        }

        public override void WirdAngegriffen(AntMe.Deutsch.Ameise ameise)
        {
            verhalten.WirdAngegriffen(ameise);
        }

        public override void WirdAngegriffen(Wanze wanze)
        {
            verhalten.WirdAngegriffen(wanze);
        }

        public override void WirdMüde()
        {
            verhalten.WirdMüde();
        }

        public override void ZielErreicht(Obst obst)
        {
            verhalten.ZielErreicht(obst);
        }

        public override void ZielErreicht(Zucker zucker)
        {
            verhalten.ZielErreicht(zucker);
        }
    }
}