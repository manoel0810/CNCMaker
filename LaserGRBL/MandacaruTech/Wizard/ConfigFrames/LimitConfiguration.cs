using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    public partial class LimitConfiguration : Form
    {
        private bool HardEnable = false;
        private readonly string[] Config;
        private readonly GrblCore mCore;

        public LimitConfiguration(string[] Configurations, GrblCore mCore)
        {
            InitializeComponent();
            Config = Configurations;
            this.mCore = mCore;
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            foreach (string s in Config)
                if (s.Contains("$21="))
                    HardEnable = s.Substring(4).Equals("1");

            CB_EnableHardLimit.Checked = HardEnable;
        }

        private void CB_EnableHardLimit_Click(object sender, EventArgs e)
        {
            if (WriteConfig(21, (CB_EnableHardLimit.Checked ? "1" : "0")))
                HardEnable = CB_EnableHardLimit.Checked;
            else
            {
                MessageBox.Show("Erro ao gravar configurações. Verifique a entrada de dados e se a controladora está devidamente conectada", "Wizard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool WriteConfig(int CommandIdentifier, string Value)
        {
            if (mCore.MachineStatus == GrblCore.MacStatus.Idle)
            {
                List<GrblConfST.GrblConfParam> config = new List<GrblConfST.GrblConfParam>
                {
                    new GrblConfST.GrblConfParam(CommandIdentifier, Value)
                };

                mCore.WriteConfig(config);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
