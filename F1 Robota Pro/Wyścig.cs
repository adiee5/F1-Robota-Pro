using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace F1_Robota_Pro
{
    class Wyścig
    {
        const string metaDataJson = "MetaData", teamsJson="Teams";
        public static string Run(int okrążenia, bool Deszcz, bool NoDnf)
        {
            string output="";

            #region Ładowanie JSON
            string jsonK = SaveMan.Wczytaj(metaDataJson);
            string jsonZ = SaveMan.Wczytaj(teamsJson);
            if (jsonK == null || jsonK == "" || jsonK == "{}" || jsonK == "{{}}")
            {
                MessageBox.Show("Nie ma Kierowców.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (jsonZ == null || jsonZ == "" || jsonZ == "{}" || jsonZ == "{{}}")
            {
                MessageBox.Show("Nie ma Zespołów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            Dictionary<string, Kierowca> Kierowcy = JsonConvert.DeserializeObject<Dictionary<string, Kierowca>>(jsonK);
            Dictionary<string, Zespół> Zespoły = JsonConvert.DeserializeObject<Dictionary<string, Zespół>>(jsonZ);
            #endregion

            Dictionary<string, WynikiKierowców> wyniki = new Dictionary<string, WynikiKierowców>();

            Random random = new Random();

            SaveMan.DopiszDoLogów($"\n\n*{DateTime.Now} | F1 Robota Pro Race*:\n");

            for(int okr=1; okr <= okrążenia; okr++)
            {
                SaveMan.DopiszDoLogów($"\nOkrążenie nr {okr}:\n\n");

                foreach(var kiero in Kierowcy)
                {
                    Zespół zespół=new Zespół();bool doable = true;double wynik = 0;int dnfKiero = 1, dnfZesp = 1;string Wynik = "¯\\_(ツ)_/¯", dnfReason = "";
                    
                    if(kiero.Value.Team==null||!Zespoły.TryGetValue(kiero.Value.Team,out zespół))
                    {
                        MessageBox.Show($"Nazwa \"{kiero.Value.Team}\" nie została rozpoznana jako prawidłowa nazwa zespołu.", "Błąd ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        doable = false;
                    }

                    if (!NoDnf)
                    {
                        if (zespół.DnfChance != 0)
                        {
                            dnfZesp = random.Next(Int32.MinValue, Int32.MaxValue) % zespół.DnfChance;
                        }
                        if (kiero.Value.Dnf != 0)
                        {
                            dnfKiero = random.Next(Int32.MinValue, Int32.MaxValue) % kiero.Value.Dnf;
                        }
                        if (dnfZesp == 0)
                        {
                            doable = false;
                            string i = Fuck.Sake(kiero.Key);
                            dnfReason = $"\nDnf reason (Zespół): {i}";
                            MessageBox.Show(i, "DNF (Zespół)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Wynik = "dnf (Zespół)";
                        }
                        if (dnfKiero == 0)
                        {
                            doable = false;
                            string i = Fuck.Sake(kiero.Key, true);
                            dnfReason = $"\nDnf reason (Kierowca): {i}";
                            MessageBox.Show(i, "DNF (Kierowca)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Wynik = "dnf (Kierowca)";
                        }
                    }
                    
                    if (doable)
                    {
                        wynik = ((double)random.Next(Deszcz?kiero.Value.RainMin:kiero.Value.Min, Deszcz ? kiero.Value.RainMax : kiero.Value.Max)) / 1000 + zespół.LoopTime;
                        Wynik = $"{wynik}";
                    }
                    if (wyniki.ContainsKey(kiero.Key))
                    {
                        wynik += wyniki[kiero.Key].czas;
                        if (!wyniki[kiero.Key].nofail) doable = wyniki[kiero.Key].nofail;
                        wyniki.Remove(kiero.Key);
                    }
                    wyniki.Add(kiero.Key, new WynikiKierowców(wynik, doable));
                    SaveMan.DopiszDoLogów($"{kiero.Key} = {Wynik}{dnfReason}\n");
                }
            }
            foreach (var kierowca in wyniki)
            {
                string OutptCache = output; string ewron;
                if (kierowca.Value.nofail) ewron = kierowca.Value.czas.ToString();
                else ewron = @"¯\_(ツ)_/¯";
                output = $"{OutptCache}{Environment.NewLine}{kierowca.Key} = {ewron}";
            }
            SaveMan.DopiszDoLogów($"\nfinal results:\n{output}");
            MessageBox.Show("Symulacja zakończona!", "Hurra!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return output;
        }
    }
}
