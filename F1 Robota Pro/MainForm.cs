using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace F1_Robota_Pro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonKierowca_Click(object sender, EventArgs e)
        {
            new KierowcyForm().Show();
        }

        private void buttonZespoły_Click(object sender, EventArgs e)
        {
            new ZespołyForm().ShowDialog();
        }

        private void otwórzFolderZUstawieniamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\F1 Robota Pro\\");
        }

        private void buttonWyścig_Click(object sender, EventArgs e)
        {
            output.Text=Wyścig.Run((int)numLoops.Value, checkDeszcz.Checked, checkNoDnf.Checked);
            btnExportCsv.Enabled=true;
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            //ExportCsv(null);
            csvExportWindow.ShowDialog();
        }

        private void csvExportWindow_FileOk(object sender, CancelEventArgs e)
        {
            string tabelka = ExportCsv();
            //ExportCsv(csvExportWindow.FileNames);
            foreach (string l in csvExportWindow.FileNames)
            {
                SaveMan.ZapiszPlik(l, tabelka,Encoding.Default);
                MessageBox.Show($"Plik \"{l}\" został zapisany.", "Export do Tabelki", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        string ExportCsv()
        {
            var Kiero = JsonConvert.DeserializeObject<Dictionary<string, Kierowca>>(SaveMan.Wczytaj("MetaData"));
            Dictionary<string, double> BigL = new Dictionary<string, double>();
            string[] sep = { " = " };
            string[] enter = { Environment.NewLine };
            foreach (string k in output.Text.Split(enter,StringSplitOptions.None))
            {
                double d;
                string[] r = k.Split(sep,StringSplitOptions.None);
                if (r.Length < 2) continue;
                if(!double.TryParse(r[1], out d)) d = double.PositiveInfinity;
                BigL.Add(r[0], d);
            }
            var y = BigL.ToList();y.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            //byte[] ó = { 0xEA, 0xb3, 0xf3, 0x9f };
            string tabelka = $"Nr.;Imię;Zespoły;Czas;Strata;Opóźnienie";int miejsce=1;double poprzedni=double.NegativeInfinity;
            foreach(var g in y)
            {
                //if (g.Value == double.PositiveInfinity)
                //{
                //    tabDnf += $"\n-,{g.Key},{Kiero[g.Key].Team},DNF,DNF";
                //}
                //else
                //{
                    tabelka += $"\n{miejsce};{g.Key};{Kiero[g.Key].Team};\"{(g.Value == double.PositiveInfinity?"dnf":g.Value.ToString())}\";\"{(g.Value == double.PositiveInfinity ? "dnf" : (g.Key==y[0].Key ? "leader" : (g.Value-y[0].Value).ToString("N3")))}\";\"{(g.Value == double.PositiveInfinity ? "dnf" : (poprzedni == double.NegativeInfinity ? "leader" : (g.Value-poprzedni).ToString("N3")))}\"";
                    miejsce++;
                    poprzedni = g.Value;
                //}
            }
            return tabelka;
        }

        private void mcLarenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(global::F1_Robota_Pro.Properties.Resources.McLaren).Play();
        }

        private void atakujeMnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(global::F1_Robota_Pro.Properties.Resources.Atakuje_mnie).Play();

        }

        private void resetujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMan.Usuń("PolePos");
            MessageBox.Show("Pola startowe zostały zresetowane.", "Pola Startowe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PolePosForm().ShowDialog();
        }

        private void zczytajZOutputuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> BigL = new Dictionary<string, double>();
            Dictionary<string, short> SmallL = new Dictionary<string, short>();
            string[] sep = { " = " };
            string[] enter = { Environment.NewLine };
            foreach (string k in output.Text.Split(enter, StringSplitOptions.None))
            {
                double d;
                string[] r = k.Split(sep, StringSplitOptions.None);
                if (r.Length < 2) continue;
                if (!double.TryParse(r[1], out d)) d = double.PositiveInfinity;
                BigL.Add(r[0], d);
            }
            var y = BigL.ToList(); y.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            short miejsce = 0;
            foreach(var g in y)
            {
                SmallL.Add(g.Key, miejsce);
                miejsce++;
            }
            SaveMan.Zapisz("PolePos", JsonConvert.SerializeObject(SmallL));
            MessageBox.Show("Wyniki kwalifikacji zostały zczytane do pól startowych.", "Zczytywanie z Outputu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
