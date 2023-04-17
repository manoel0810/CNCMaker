using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    public partial class HomingConfiguration : Form
    {
        private bool HommingEnable = false;
        private readonly string[] Config;
        private readonly GrblCore mCore;

        public HomingConfiguration(string[] Configurations, GrblCore mCore)
        {
            InitializeComponent();
            Config = Configurations;
            this.mCore = mCore;
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            foreach (string s in Config)
                if (s.Contains("$22="))
                    HommingEnable = s.Substring(4).Equals("1");

            CB_HommingEnable.Checked = HommingEnable;
        }

        private void CB_EnableHomming_Click(object sender, EventArgs e)
        {
            if (WriteConfig(22, (CB_HommingEnable.Checked ? "1" : "0")))
                HommingEnable = CB_HommingEnable.Checked;
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
