﻿using System;
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
        const string plik = "MetaData";

        public KierowcyForm()
        {
            InitializeComponent();
        }

        private void KierowcyForm_Load(object sender, EventArgs e)
        {
            string zyt = SaveMan.Wczytaj("Teams");
            if(zyt==null||zyt==""||zyt == "{}" || zyt == "{{}}")
            {
                MessageBox.Show("Zanim będziesz konfigurował kierowców, wpierw skonfiguruj Zespoły.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Close();
                return;
            }
            Zespoły = JsonConvert.DeserializeObject<Dictionary<string, Zespół>>(zyt);

            string odczyt = SaveMan.Wczytaj(plik);
            if (odczyt == null||odczyt==""||odczyt=="{}"||odczyt=="{{}}"||odczyt=="null")
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
            numRainMin.Value = Kierowcy[cmbKierowcy.Text].RainMin;
            numRainMax.Value = Kierowcy[cmbKierowcy.Text].RainMax;
            numDnf.Value = Kierowcy[cmbKierowcy.Text].Dnf;
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            string k = SaveMan.NameDialog("Kierowc");

            try { Kierowcy.Add(k, new Kierowca()); }
            catch
            {
                MessageBox.Show($"Nazwa \"{k}\" już istnieje, lub jest niepoprawna, spróbuj jescze raz.", "Dodanie Kierowcy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
            MessageBox.Show($"Dodano \"{k}\" do listy kierowców.", "Dodanie Kierowcy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        #region Obecny Kierowca
        private void SetButton_Click(object sender, EventArgs e)
        {
            if (numMin.Value == numMax.Value)
            {
                MessageBox.Show("Liczby zakresu nie mogą być równe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numMin.Value > numMax.Value)
            {
                decimal żyd = numMin.Value;
                numMin.Value = numMax.Value;
                numMax.Value = żyd;
            }
            if (numRainMin.Value == numRainMax.Value)
            {
                MessageBox.Show("Liczby zakresu nie mogą być równe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numRainMin.Value > numRainMax.Value)
            {
                decimal żyd = numRainMin.Value;
                numRainMin.Value = numRainMax.Value;
                numRainMax.Value = żyd;
            }

            Kierowcy[cmbKierowcy.Text] = new Kierowca(cmbTeam.Text, (int)numMin.Value, (int)numMax.Value,(int)numRainMin.Value,(int)numRainMax.Value,(int)numDnf.Value);
            MessageBox.Show("Zmiany zostały zatwierdzone.", "Zatwierdzono", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zmieńNazwęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Chcesz zmienić nazwę Kierowcy \"{cmbKierowcy.Text}\"?","Zmiana Nazwy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Zmiana Nazwy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string k = SaveMan.NameDialog("Kierowc", false);

            try { Kierowcy.Add(k, Kierowcy[cmbKierowcy.Text]); }
            catch
            {
                MessageBox.Show($"Nazwa \"{k}\" już istnieje, lub jest niepoprawna, spróbuj jescze raz.", "Kopiowanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Nazwa Kierowcy \"{cmbKierowcy.Text}\" została zmieniona na \"{k}\".", "Zmiana Nazwy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Kierowcy.Remove(cmbKierowcy.Text);
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
        }

        private void kopiujDoNowegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string k = SaveMan.NameDialog("Kierowc", false);
            try { Kierowcy.Add(k, Kierowcy[cmbKierowcy.Text]); } 
            catch 
            {
                MessageBox.Show($"Nazwa \"{k}\" już istnieje, lub jest niepoprawna, spróbuj jescze raz.", "Kopiowanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
            MessageBox.Show($"Skopiowano Kierowcę \"{cmbKierowcy.Text}\" do \"{k}\".", "Kopiowanie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Chcesz usunąć Kierowcę \"{cmbKierowcy.Text}\"?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Zmiana Nazwy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Kierowca \"{cmbKierowcy.Text}\" został usunięty", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Kierowcy.Remove(cmbKierowcy.Text);
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
        }
        #endregion

        private void usuńWszystkichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Czy chcesz usunąć wszystkich kierowców?", "Usuwanie wszystkich kierowców", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Usuwanie wszystkich kierowców", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Napewno?", "Usuwanie wszystkich kierowców", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Usuwanie wszystkich kierowców", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Kierowcy = new Dictionary<string, Kierowca>();
            MessageBox.Show("Pomyślnie Usunięto wszystkich kierowców.", "Usuwanie wszystkich kierowców", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Kierowcy.Add(SaveMan.NameDialog("kierowc"), new Kierowca());
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
        }

        private void cofnijWszystkieOstatnieZmianyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Chcesz cofnąć wsystkie zmiany, jakie zostały dokonane po otwarciu tego okna? Tej akcji nie da się cofnąć!", "Cofanie Wszystkich Ostatnich Zmian", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Cofanie Wszystkich Ostatnich Zmian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Napewno? TEJ AKCJI NIE DA SIĘ COFNĄĆ!!!", "Cofanie Wszystkich Ostatnich Zmian", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Cofanie Wszystkich Ostatnich Zmian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Pomyślnie cofnięto wszystkie zmiany.", "Cofanie Wszystkich Ostatnich Zmian", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            string odczyt = SaveMan.Wczytaj(plik);
            if (odczyt == null || odczyt == "" || odczyt == "{}" || odczyt == "{{}}")
            {
                Kierowcy = new Dictionary<string, Kierowca>();
                Kierowcy.Add(SaveMan.NameDialog("kierowc"), new Kierowca());
            }
            else Kierowcy = JsonConvert.DeserializeObject<Dictionary<string, Kierowca>>(odczyt);
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
            Ładuj();
        }

        private void KierowcyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMan.Zapisz(plik, JsonConvert.SerializeObject(Kierowcy));
        }

        private void importujZMetaDatatxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Czy chcesz zaimportować dane z pliku MetaData.txt? Spowoduje to usunięcie wszystkich obecnych kierowców.", "Importowanie z MetaData.txt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Importowanie z MetaData.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Napewno?", "Importowanie z MetaData.txt", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Importowanie z MetaData.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nj = SaveMan.WczytajPlik(".\\MetaData.txt");
            if (nj == null)
            {
                MessageBox.Show("Umieść plik MetaData.txt w tym samym folderze, co Program.", "Importowanie z MetaData.txt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            Kierowcy = new Dictionary<string, Kierowca>();

            foreach (string line in nj.Split('\n'))
            {
                string[]hyd=line.Split('|');
                Kierowcy.Add(hyd[1], new Kierowca(hyd[0], int.Parse(hyd[2]), int.Parse(hyd[3]), int.Parse(hyd[2]), int.Parse(hyd[3]),0));
            }
            cmbKierowcy.DataSource = Kierowcy.Keys.ToList();
            MessageBox.Show("Pomyślnie zaimportowano wszystkich Kierowców z MetaData.txt. " +
                            "Zalecane Jest sprawdzenie, czy Zespoły z zaimportowanych kierowców istnieją.\n\n" +
                            "UWAGA - W F1 Robota Pro nazwy zespołów są czułe na Wielkość Liter i Spacje!", "Importowanie z MetaData.txt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
