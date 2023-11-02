using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    public partial class CalibrationForm : Form
    {
        private readonly GrblCore mCore;
        private readonly string[] Config;
        readonly int[] POS = new int[] { 0, 0, 0 };
        private readonly decimal[] parahm = new decimal[] { 0, 0, 0 };
        private readonly GPoint mPoint;

        public CalibrationForm(string[] Configurations, GrblCore mCore)
        {
            InitializeComponent();
            Config = Configurations;
            this.mCore = mCore;
            mPoint = mCore.MachinePosition;

            LoadConfiguration();
        }

        private void Btn_ZP_Click(object sender, EventArgs e)
        {
            var obj = (Button)sender;
            int selectedbutton = -1;
            float initialAxysValue = 0;

            switch (obj.Text)
            {
                case "X+":
                    POS[0] += 10;
                    selectedbutton = 0;
                    initialAxysValue = mPoint.X;
                    break;
                case "Y+":
                    POS[1] += 10;
                    selectedbutton = 1;
                    initialAxysValue = mPoint.Y;
                    break;
                case "Z+":
                    POS[2] += 10;
                    selectedbutton = 2;
                    initialAxysValue = mPoint.Z;
                    break;
            }

            if (selectedbutton == -1)
                return;

            string command = $"G0 {obj.Text.Substring(0, 1)}{(POS[selectedbutton] + initialAxysValue).ToString().Replace(",", ".")}";
            ExecuteQuery(command);
            UpdateLabel(selectedbutton);
        }

        private void Btn_ZM_Click(object sender, EventArgs e)
        {
            var obj = (Button)sender;
            int selectedbutton = -1;
            float initialAxysValue = 0;

            switch (obj.Text)
            {
                case "X-":
                    POS[0] -= 10;
                    selectedbutton = 0;
                    initialAxysValue = mPoint.X;
                    break;
                case "Y-":
                    POS[1] -= 10;
                    selectedbutton = 1;
                    initialAxysValue = mPoint.Y;
                    break;
                case "Z-":
                    POS[2] -= 10;
                    selectedbutton = 2;
                    initialAxysValue = mPoint.Z;
                    break;
            }

            if (selectedbutton == -1)
                return;

            string command = $"G0 {obj.Text.Substring(0, 1)}{(POS[selectedbutton] + initialAxysValue).ToString().Replace(",", ".")}";
            ExecuteQuery(command);
            UpdateLabel(selectedbutton);
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
                if (s.Contains("$100=") || s.Contains("$101=") || s.Contains("$102="))  //100 = X 101 = Y 102 = Z
                {
                    string mask = s.Substring(5).Replace(".", ",");
                    if (s.Contains("$100="))
                        parahm[0] = decimal.Parse(mask);
                    else if (s.Contains("$101="))
                        parahm[1] = decimal.Parse(mask);
                    else if (s.Contains("$102="))
                        parahm[2] = decimal.Parse(mask);
                }

            NX.Value = parahm[0];
            NY.Value = parahm[1];
            NZ.Value = parahm[2];
        }

        private void UpdateLabel(int WHOS)
        {
            switch (WHOS)
            {
                case 0:
                    PX.Text = $"{POS[0]}.0 mm";
                    break;
                case 1:
                    PY.Text = $"{POS[1]}.0 mm";
                    break;
                case 2:
                    PZ.Text = $"{POS[2]}.0 mm";
                    break;
            }
        }

        private void RMX_ValueChanged(object sender, EventArgs e)
        {
            //Os valores são iguais. Não necessita modificação
            if (((double)RMX.Value).Equals(Math.Abs(POS[0])))
            {
                NX.Value = parahm[0];
                NX.ForeColor = Color.Black;
                UpdateX.Enabled = false;
                return;
            }
            else if (RMX.Value <= 0)
                return;


            Calculate(Math.Abs(POS[0]), RMX.Value, 'X');
        }

        private void RMY_ValueChanged(object sender, EventArgs e)
        {
            //Os valores são iguais. Não necessita modificação
            if (((double)RMY.Value).Equals(Math.Abs(POS[1])))
            {
                NY.Value = parahm[1];
                NY.ForeColor = Color.Black;
                UpdateY.Enabled = false;
                return;
            }
            else if (RMY.Value <= 0)
                return;

            Calculate(Math.Abs(POS[1]), RMY.Value, 'Y');
        }

        private void RMZ_ValueChanged(object sender, EventArgs e)
        {
            //Os valores são iguais. Não necessita modificação
            if (((double)RMZ.Value).Equals(Math.Abs(POS[2])))
            {
                NZ.Value = parahm[2];
                NZ.ForeColor = Color.Black;
                UpdateZ.Enabled = false;
                return;
            }
            else if (RMZ.Value <= 0)
                return;

            Calculate(Math.Abs(POS[2]), RMZ.Value, 'Z');
        }

        private void Calculate(int SentMoviment, decimal RealMoviment, char Axys)
        {

            decimal X;
            decimal S = SentMoviment;
            decimal R = RealMoviment;
            decimal AxysRate = 0;

            switch (Axys)
            {
                case 'X':
                    AxysRate = parahm[0];
                    break;
                case 'Y':
                    AxysRate = parahm[1];
                    break;
                case 'Z':
                    AxysRate = parahm[2];
                    break;
            }

            if (R > 0)
                X = (AxysRate * S) / R;
            else
                X = 0;

            switch (Axys)
            {
                case 'X':
                    NX.Value = X;
                    NX.ForeColor = Color.Red;
                    UpdateX.Enabled = true;
                    break;
                case 'Y':
                    NY.Value = X;
                    NY.ForeColor = Color.Red;
                    UpdateY.Enabled = true;
                    break;
                case 'Z':
                    NZ.Value = X;
                    NZ.ForeColor = Color.Red;
                    UpdateZ.Enabled = true;
                    break;
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

        private void UpdateX_Click(object sender, EventArgs e)
        {
            if (WriteConfig(100, decimal.Parse(NX.Value.ToString()).ToString("0.000").Replace(",", ".")))
            {
                parahm[0] = (int)NX.Value;
                UpdateX.Enabled = false;
                NX.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Erro ao gravar configurações. Verifique a entrada de dados e se a controladora está devidamente conectada", "Wizard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void UpdateY_Click(object sender, EventArgs e)
        {
            if (WriteConfig(101, decimal.Parse(NY.Value.ToString()).ToString("0.000").Replace(",", ".")))
            {
                parahm[1] = (int)NX.Value;
                UpdateY.Enabled = false;
                NY.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Erro ao gravar configurações. Verifique a entrada de dados e se a controladora está devidamente conectada", "Wizard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateZ_Click(object sender, EventArgs e)
        {
            if (WriteConfig(102, decimal.Parse(NZ.Value.ToString()).ToString("0.000").Replace(",", ".")))
            {
                parahm[2] = (int)NX.Value;
                UpdateZ.Enabled = false;
                NZ.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Erro ao gravar configurações. Verifique a entrada de dados e se a controladora está devidamente conectada", "Wizard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Zerar_Click(object sender, EventArgs e)
        {
            ExecuteQuery($"G0 X{QFormat(mPoint.X)} Y{QFormat(mPoint.Y)} Z{QFormat(mPoint.Z)}");
            for (int i = 0; i < POS.Length; i++)
            {
                POS[i] = 0;
                UpdateLabel(i);
            }

            RMX.Value = 0;
            RMY.Value = 0;
            RMZ.Value = 0;
        }

        private string QFormat(float f) { return f.ToString().Replace(",", "."); }
    }
}
