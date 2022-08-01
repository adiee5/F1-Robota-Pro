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
    public partial class KierowcyForm : Form
    {
        Dictionary<string, Kierowca> Kierowcy;
        Dictionary<string, Zespół> Zespoły;

        public KierowcyForm()
        {
            InitializeComponent();
        }

        private void KierowcyForm_Load(object sender, EventArgs e)
        {
            string zyt = SaveMan.Wczytaj("Teams");
            if(zyt==null||zyt==""||zyt == "{}" || zyt == "{{}}")
            {
                MessageBox.Show("Zanim będziesz konfigurował kierowców, wpierw skonfiguruj Zespoły","błąd",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Close();
                return;
            }
            Zespoły = JsonConvert.DeserializeObject<Dictionary<string, Zespół>>(zyt);

            string odczyt = SaveMan.Wczytaj("MetaData");
            if (odczyt == null||odczyt==""||odczyt=="{}"||odczyt=="{{}}")
            {
                Kierowcy = new Dictionary<string, Kierowca>();
                Kierowcy.Add(SaveMan.NameDialog("kierowc"), new Kierowca());
            }
            else Kierowcy = JsonConvert.DeserializeObject<Dictionary<string, Kierowca>>(odczyt);
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
            cmbTeam.DataSource = Zespoły.Keys.ToList();
            Ładuj();
        }

        private void cmbKierowcy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ładuj();
        }
        void Ładuj()
        {
            cmbTeam.Text = Kierowcy[cmbKierowcy.Text].Team;
            numMin.Value = Kierowcy[cmbKierowcy.Text].Min;
            numMax.Value = Kierowcy[cmbKierowcy.Text].Max;
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            Kierowcy.Add(SaveMan.NameDialog("Kierowc"),new Kierowca());
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
        }
    }
}
