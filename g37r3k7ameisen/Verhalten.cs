using System.Collections.Generic;
using AntMe.Deutsch;

namespace AntMe.Player.g37r3k7ameisen
{
    public interface IVerhalten
    {
        string BestimmeKaste(Dictionary<string, int> anzahl);
        void IstGestorben(Todesart todesart);
        void RiechtFreund(Markierung markierung);
        void Sieht(Obst obst);
        void Sieht(Zucker zucker);
        void SiehtFeind(AntMe.Deutsch.Ameise ameise);
        void SiehtFeind(Wanze wanze);
        void SiehtFreund(AntMe.Deutsch.Ameise ameise);
        void SiehtVerbündeten(AntMe.Deutsch.Ameise ameise);
        void Tick();
        void Wartet();
        void WirdAngegriffen(AntMe.Deutsch.Ameise ameise);
        void WirdAngegriffen(Wanze wanze);
        void WirdMüde();
        void ZielErreicht(Obst obst);
        void ZielErreicht(Zucker zucker);
    }
}