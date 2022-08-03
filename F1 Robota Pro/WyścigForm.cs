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
    public partial class WyścigForm : Form
    {
        int Okrążenia;bool Deszcz;
        public WyścigForm(int okrążenia, bool deszcz)
        {
            Okrążenia = okrążenia;
            Deszcz = deszcz;
            InitializeComponent();
        }

        private void WyścigForm_Load(object sender, EventArgs e)
        {
            output.Text = Wyścig.Run(Okrążenia, Deszcz);
        }
    }
}
