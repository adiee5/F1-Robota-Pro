using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.Json;
using Newtonsoft.Json;

namespace F1_Robota_Pro
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //JsonTest();
            //Jsoner();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /*static void JsonTest()
        {
            List<Kierowca> kierowcas = new List<Kierowca>();
            kierowcas.Add(new Kierowca("zz", 1, 2));
            kierowcas.Add(new Kierowca("33", 1000, 2));
            string z = JsonConvert.SerializeObject(kierowcas);//JsonSerializer.Serialize(kierowcas);

            Dictionary<string, Kierowca> żyd = new Dictionary<string, Kierowca>();
            żyd.Add("fuj", new Kierowca("sssss", 1, 2));
            żyd.Add("huj", new Kierowca("eee0", 5, 6));
            //var m = żyd["luj"];
            string n = JsonConvert.SerializeObject(żyd);

            SaveMan.Zapisz("Teams", n);

            var k = JsonConvert.DeserializeObject<List<Kierowca>>(z);
            var ż = JsonConvert.DeserializeObject<Dictionary<string, Kierowca>>(n);
        }*/
        static void Jsoner()
        {
            Dictionary<string, Zespół> i = new Dictionary<string, Zespół>();
            i.Add("r", new Zespół(190.3, 6));
            i.Add("z", new Zespół(4.3, 2));

            SaveMan.Zapisz("Teams", JsonConvert.SerializeObject(i));
        }
    }
}
