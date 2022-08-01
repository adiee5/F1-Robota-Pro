using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Robota_Pro
{
    public partial class DodajForm : Form
    {
        bool _nowy;
        string _plik, nazw;
        public DodajForm(string plik,string nazwa,bool nowy =true)
        {
            _nowy = nowy;
            _plik = plik;
            nazw = nazwa;
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            SaveMan.ZapiszPlik(_plik, NazwaBox.Text);
            Close();
        }

        private void DodajForm_Load(object sender, EventArgs e)
        {
            Text = _nowy ? $"Dodaj {nazw}ę" : $"Zmień nazwę {nazw}y";
        }

    }
}
