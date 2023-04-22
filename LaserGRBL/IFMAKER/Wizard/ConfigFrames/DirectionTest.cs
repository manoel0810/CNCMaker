using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    public partial class DirectionTest : Form
    {
        readonly int[] POS = new int[] { 0, 0, 0 };
        private string[] Config;
        private readonly GrblCore mCore;
        private readonly GPoint mPoint;

        public DirectionTest(string[] Configurations, GrblCore mCore)
        {
            InitializeComponent();
            Config = Configurations;
            this.mCore = mCore;
            mPoint = mCore.MachinePosition;

            LoadConfiguration();
        }

        private void Btn_XP_Click(object sender, EventArgs e)
        {
            var obj = (Button)sender;
            int selectedbutton = -1;
            float initialAxysValue = 0;

            switch (obj.Text)
            {
                case "X+":
                    POS[0] += 1;
                    selectedbutton = 0;
                    initialAxysValue = mPoint.X;
                    break;
                case "Y+":
                    POS[1] += 1;
                    selectedbutton = 1;
                    initialAxysValue = mPoint.Y;
                    break;
                case "Z+":
                    POS[2] += 1;
                    selectedbutton = 2;
                    initialAxysValue = mPoint.Z;
                    break;
            }

            if (selectedbutton == -1)
                return;

            string command = $"G0 {obj.Text.Substring(0, 1)}{(POS[selectedbutton] + initialAxysValue).ToString().Replace(",", ".")}";
            ExecuteQuery(command);
        }

        private void Btn_XM_Click(object sender, EventArgs e)
        {
            var obj = (Button)sender;
            int selectedbutton = -1;
            float initialAxysValue = 0;

            switch (obj.Text)
            {
                case "X-":
                    POS[0] -= 1;
                    selectedbutton = 0;
                    initialAxysValue = mPoint.X;
                    break;
                case "Y-":
                    POS[1] -= 1;
                    selectedbutton = 1;
                    initialAxysValue = mPoint.Y;
                    break;
                case "Z-":
                    POS[2] -= 1;
                    selectedbutton = 2;
                    initialAxysValue = mPoint.Z;
                    break;
            }

            if (selectedbutton == -1)
                return;

            string command = $"G0 {obj.Text.Substring(0, 1)}{(POS[selectedbutton] + initialAxysValue).ToString().Replace(",", ".")}";
            ExecuteQuery(command);
        }

        private void ExecuteQuery(string query)
        {
            if (mCore.MachineStatus == GrblCore.MacStatus.Idle)
                mCore.EnqueueCommand(new GrblCommand(query, 0, true));
            else
            {
                MessageBox.Show("O acesso ao dispositivo está indisponível no momento", "Serial Com", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void LoadConfiguration()
        {
            foreach (string s in Config)
                if (s.Contains("$3="))
                {
                    int i = 0;
                    string mask = s.Substring(3);
                    bool[] parahm = new bool[] { false, false, false };
                    foreach (char c in mask)
                        parahm[i++] = c == '1';

                    Cb_InvertedZ.Checked = parahm[0];
                    Cb_InvertedY.Checked = parahm[1];
                    Cb_InvertedX.Checked = parahm[2];
                }
        }

        private void Cb_InvertedX_Click(object sender, EventArgs e)
        {
            string mask = $"{(Cb_InvertedZ.Checked ? "1" : "0")}" +
                $"{(Cb_InvertedY.Checked ? "1" : "0")}" +
                $"{(Cb_InvertedX.Checked ? "1" : "0")}";

            List<GrblConfST.GrblConfParam> config = new List<GrblConfST.GrblConfParam>
            {
                new GrblConfST.GrblConfParam(3, mask)
            };

            mCore.WriteConfig(config);
        }

        public void RealoadOptions(string[] newops)
        {
            Config = newops;
            LoadConfiguration();
        }
    }
}
