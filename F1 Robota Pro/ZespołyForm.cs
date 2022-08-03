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
    public partial class ZespołyForm : Form
    {
        Dictionary<string, Zespół> Zespoły;
        //Dictionary<string, Zespół> Zespoły;
        const string plik = "Teams";

        public ZespołyForm()
        {
            InitializeComponent();
        }

        private void KierowcyForm_Load(object sender, EventArgs e)
        {
            string odczyt = SaveMan.Wczytaj(plik);
            if (odczyt == null||odczyt==""||odczyt=="{}"||odczyt=="{{}}")
            {
                Zespoły = new Dictionary<string, Zespół>();
                Zespoły.Add(SaveMan.NameDialog("Drużyn"), new Zespół());
            }
            else Zespoły = JsonConvert.DeserializeObject<Dictionary<string, Zespół>>(odczyt);
            cmbZespoły.DataSource = Zespoły.Keys.ToList();
            Ładuj();
        }

        private void cmbKierowcy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ładuj();
        }
        void Ładuj()
        {
            numDnf.Value = Zespoły[cmbZespoły.Text].DnfChance;
            txbLoopTime.Text = Zespoły[cmbZespoły.Text].LoopTime.ToString();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            string k = SaveMan.NameDialog("Dryżyn");

            try { Zespoły.Add(k, new Zespół()); }
            catch
            {
                MessageBox.Show($"Nazwa \"{k}\" już istnieje, lub jest niepoprawna, spróbuj jescze raz.", "Dodanie Zespołu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbZespoły.DataSource = Zespoły.Keys.ToList();
            MessageBox.Show($"Dodano \"{k}\" do listy zespołów.", "Dodanie Zespołu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        #region Obecny Kierowca
        private void SetButton_Click(object sender, EventArgs e)
        {
            double ch;
            if(!double.TryParse(txbLoopTime.Text,out ch))
            {
                MessageBox.Show("Wartość wprowadzona w Osiągach jest niepoprawna.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Zespoły[cmbZespoły.Text] = new Zespół(ch,(int)numDnf.Value);
            MessageBox.Show("Zmiany zostały zatwierdzone.", "Zatwierdzono", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zmieńNazwęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Chcesz zmienić nazwę Zespołu \"{cmbZespoły.Text}\"?","Zmiana Nazwy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Zmiana Nazwy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string k = SaveMan.NameDialog("Drużyn", false);

            try { Zespoły.Add(k, Zespoły[cmbZespoły.Text]); }
            catch
            {
                MessageBox.Show($"Nazwa \"{k}\" już istnieje, lub jest niepoprawna, spróbuj jescze raz.", "Kopiowanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Nazwa Zespołu \"{cmbZespoły.Text}\" została zmieniona na \"{k}\".", "Zmiana Nazwy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Zespoły.Remove(cmbZespoły.Text);
            cmbZespoły.DataSource = Zespoły.Keys.ToList();
        }

        private void kopiujDoNowegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string k = SaveMan.NameDialog("Drużyn", false);
            try { Zespoły.Add(k, Zespoły[cmbZespoły.Text]); } 
            catch 
            {
                MessageBox.Show($"Nazwa \"{k}\" już istnieje, lub jest niepoprawna, spróbuj jescze raz.", "Kopiowanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmbZespoły.DataSource = Zespoły.Keys.ToList();
            MessageBox.Show($"Skopiowano Zespół \"{cmbZespoły.Text}\" do \"{k}\".", "Kopiowanie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Chcesz usunąć Zespół \"{cmbZespoły.Text}\"?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Zmiana Nazwy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Zespół \"{cmbZespoły.Text}\" został usunięty", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Zespoły.Remove(cmbZespoły.Text);
            cmbZespoły.DataSource = Zespoły.Keys.ToList();
        }
        #endregion

        private void usuńWszystkichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Czy chcesz usunąć wszystkie zespoły?", "Usuwanie wszystkich zespołów", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Usuwanie wszystkich zespołów", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Napewno?", "Usuwanie wszystkich zespołów", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                MessageBox.Show("Operacja Anulowana.", "Usuwanie wszystkich zespołów", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Zespoły = new Dictionary<string, Zespół>();
            MessageBox.Show("Pomyślnie Usunięto wszystkich kierowców.", "Usuwanie wszystkich zespołów", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Zespoły.Add(SaveMan.NameDialog("drużyn"), new Zespół());
            cmbZespoły.DataSource = Zespoły.Keys.ToList();
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
                Zespoły = new Dictionary<string, Zespół>();
                Zespoły.Add(SaveMan.NameDialog("drużyn"), new Zespół());
            }
            else Zespoły = JsonConvert.DeserializeObject<Dictionary<string, Zespół>>(odczyt);
            cmbZespoły.DataSource = Zespoły.Keys.ToList();
            Ładuj();
        }

        private void KierowcyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMan.Zapisz(plik, JsonConvert.SerializeObject(Zespoły));
        }
    }
}
