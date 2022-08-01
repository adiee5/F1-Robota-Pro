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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonKierowca_Click(object sender, EventArgs e)
        {
            new KierowcyForm().ShowDialog();
        }

        private void buttonZespoły_Click(object sender, EventArgs e)
        {
            
        }

    }
}
