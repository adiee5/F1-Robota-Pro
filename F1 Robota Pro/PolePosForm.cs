using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace F1_Robota_Pro
{
    public partial class PolePosForm : Form
    {
        Dictionary<string, short> Pozycje;
        Dictionary<string, Kierowca> Kierowcy;
        const string plik = "PolePos";

        public PolePosForm()
        {
            InitializeComponent();
        }

        private void PolePosForm_Load(object sender, EventArgs e)
        {
            string zyt = SaveMan.Wczytaj("MetaData");
            if (zyt == null || zyt == "" || zyt == "{}" || zyt == "{{}}")
            {
                MessageBox.Show("Zanim będziesz konfigurował Pozycje Startowe, wpierw skonfiguruj Kierowców.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
                return;
            }
            Kierowcy = JsonConvert.DeserializeObject<Dictionary<string, Kierowca>>(zyt);
            string odczyt = SaveMan.Wczytaj(plik);
            if (odczyt == null||odczyt==""||odczyt=="{}"||odczyt=="{{}}") Pozycje = new Dictionary<string, short>();
            else Pozycje = JsonConvert.DeserializeObject<Dictionary<string, short>>(odczyt);
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
            Ładuj();
        }

        private void cmbKierowcy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ładuj();
        }
        void Ładuj()
        {
            Pozycje.TryGetValue(cmbKierowcy.Text,out short n);
            numPenality.Value = n;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            Pozycje[cmbKierowcy.Text] =(short)numPenality.Value;
            MessageBox.Show("Zmiany zostały zatwierdzone.", "Zatwierdzono", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PolePosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMan.Zapisz(plik, JsonConvert.SerializeObject(Pozycje));
        }

    }
}
