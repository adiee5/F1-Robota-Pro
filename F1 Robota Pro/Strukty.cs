using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Robota_Pro
{
    struct Kierowca
    {
        public string Team;public int Min, Max;
        public Kierowca(string team, int min, int max)
        {
            Team = team;Min = min;Max = max;
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
}
