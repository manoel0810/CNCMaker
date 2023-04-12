using System;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER
{
    public partial class ZSettings : Form
    {
        public static bool USE_COTE_Z = false;
        public static double Z_COTE = 0.0d;
        public DialogResult ExitResult { get; set; }

        public ZSettings()
        {
            InitializeComponent();
            ExitResult = DialogResult.None;
        }

        private void Espessura_ValueChanged(object sender, EventArgs e)
        {
            Profundidade.Maximum = Espessura.Value;
            Profundidade.Value = Espessura.Value / 2;
        }

        private void Btn_Definir_Click(object sender, EventArgs e)
        {
            USE_COTE_Z = true;
            Z_COTE = (double)Profundidade.Value;
            ExitResult = DialogResult.OK;
            Close();
        }
    }
}
