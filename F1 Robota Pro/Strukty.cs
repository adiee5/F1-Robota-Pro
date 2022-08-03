using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Robota_Pro
{
    struct Kierowca
    {
        public string Team;public int Min, Max,RainMin,RainMax,Dnf;
        public Kierowca(string team, int min, int max,int rainMin,int rainMax,int dnf)
        {
            Team = team;Min = min;Max = max;RainMin = rainMin;RainMax = rainMax;Dnf = dnf;
        }
    }
    struct Zespół
    {
        public double LoopTime; public int DnfChance;
        public Zespół(double loopTime, int dnfChance)
        {
            LoopTime = loopTime;
            DnfChance = dnfChance;
        }
    }
    struct WynikiKierowców
    {
        public double czas;
        //public string imie;
        public bool nofail;
        public WynikiKierowców(double c, bool d)
        {
            czas = c; nofail = d;
        }
    }

    class Fuck
    {
        public static string Sake(string kierowca, bool winaKiero = false)
        {
            string[] sake =
            {
                $"{kierowca} rozjebał się o innego kierowcę.",
                $"{kierowca} jebnął w ścianę.",
                $"Studzienka jebnęła w spód bolidu kierowcy \"{kierowca}\".",
                $"{kierowca} jebnął staruszkę na pasach, i dostał DQ.",
                $"Bolid kierowcy \"{kierowca}\" rozjebał się. Po prostu!",
                $"{kierowca} został postrzelony w zamachu terrorystycznym.",
                $"{kierowca} został zaatakowany przez innego kierowce i niezmieścił się do ch*ja, co on zrobił!",
                $"{kierowca} wjechał na bagniste tereny i został zaatakowany przez Shreka.",
                $"{kierowca} został zniszczony przez niebieską, latającą skorupę żółwia z kolcami.",
                $"{kierowca} został przejechany przez Giga Kubicę.",
                $"Kierowcy \"{kierowca}\" pękła opona i wtedy jebnął w ścianę.",
                $"{kierowca} dostał dnf, bo nwm, brakuje mi pomysłów ¯\\_(ツ)_/¯",
                $"/wstaw jakiś oryginalny powód dnf dla kierowcy \"{kierowca}\"/",
                $"{kierowca} zaspinował."
            };
            Random random = new Random();
            int i = sake.Length - 1;
            return (winaKiero&&(kierowca.ToLower().Contains("vettel")|| kierowca.ToLower().Contains("vetel")|| kierowca.ToLower().Contains("wettel")|| kierowca.ToLower().Contains("wetel")))
                ? $"{kierowca} zaspinował.":sake[random.Next(i)];

        }
    }
}
