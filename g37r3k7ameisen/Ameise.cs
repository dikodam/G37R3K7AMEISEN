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
        public override string BestimmeKaste(Dictionary<string, int> anzahl)
        {
            return "Standard";
        }

        public override void IstGestorben(Todesart todesart)
        {
        }

        public override void RiechtFreund(Markierung markierung)
        {
        }

        public override void Sieht(Obst obst)
        {
        }

        public override void Sieht(Zucker zucker)
        {
        }

        public override void SiehtFeind(AntMe.Deutsch.Ameise ameise)
        {
        }

        public override void SiehtFeind(Wanze wanze)
        {
        }

        public override void SiehtFreund(AntMe.Deutsch.Ameise ameise)
        {
        }

        public override void SiehtVerbündeten(AntMe.Deutsch.Ameise ameise)
        {
        }

        public override void Tick()
        {
        }

        public override void Wartet()
        {
        }

        public override void WirdAngegriffen(AntMe.Deutsch.Ameise ameise)
        {
        }

        public override void WirdAngegriffen(Wanze wanze)
        {
        }

        public override void WirdMüde()
        {
        }

        public override void ZielErreicht(Obst obst)
        {
        }

        public override void ZielErreicht(Zucker zucker)
        {
        }
    }
}