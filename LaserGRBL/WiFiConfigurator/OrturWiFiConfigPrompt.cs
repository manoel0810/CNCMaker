using System;
using System.Windows.Forms;

namespace LaserGRBL.WiFiConfigurator
{
    public partial class OrturWiFiConfigPrompt : Form
    {
        public OrturWiFiConfigPrompt(GrblCore core)
        {
            InitializeComponent();
            LblPrompt.Text = String.Format(LblPrompt.Text, core.GrblVersion?.MachineName);
        }

        private void CbDontShow_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SetObject("Suppress Ortur WiFI Message", CbDontShow.Checked);
        }
    }
}
