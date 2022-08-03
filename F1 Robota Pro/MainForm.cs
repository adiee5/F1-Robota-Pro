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
            new ZespołyForm().ShowDialog();
        }

        private void otwórzFolderZUstawieniamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\F1 Robota Pro\\");
        }

        private void buttonWyścig_Click(object sender, EventArgs e)
        {
            output.Text=Wyścig.Run((int)numLoops.Value, checkDeszcz.Checked);
            btnExportCsv.Enabled=true;
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            //ExportCsv(null);
            //csvExportWindow.ShowDialog();
        }

        private void csvExportWindow_FileOk(object sender, CancelEventArgs e)
        {
            //csvExportWindow.
            //ExportCsv(csvExportWindow.FileNames);
            Dictionary<string, double> BigL = new Dictionary<string, double>();
            string[] sep = { " = " };
            foreach (string k in output.Text.Split('\n'))
            {
                double d = double.NaN;
                string[] r = k.Split(sep, StringSplitOptions.None);
                double.TryParse(r[1], out d);
                BigL.Add(r[0], d);
            }
            BigL.ToList().Sort();
            foreach (string l in csvExportWindow.FileNames)
            {

            }

        }
        void ExportCsv(string[] v)
        {
            Dictionary<string, double> BigL = new Dictionary<string, double>();
            string[] sep = { " = " };
            string[] enter = { Environment.NewLine };
            foreach (string k in output.Text.Split(enter,StringSplitOptions.None))
            {
                double d = double.NaN;
                string[] r = k.Split(sep,StringSplitOptions.None);
                if (r.Length < 2) continue;
                double.TryParse(r[1], out d);
                BigL.Add(r[0], d);
            }
            BigL.ToList().Sort();

        }
    }
}
