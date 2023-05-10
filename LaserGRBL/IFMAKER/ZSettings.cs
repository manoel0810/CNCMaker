using System;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER
{
    public partial class ZSettings : Form
    {
        public static bool USE_COTE_Z = false;
        public static bool MULTI_LAYERS_ENABLE = false;
        public static double Z_COTE = 0.0d;
        public static double LAYERS_COTE = 0.0d;
        public static int LAYERS_COUNT = 0;

        public DialogResult ExitResult { get; set; }

        public ZSettings()
        {
            InitializeComponent();
            ExitResult = DialogResult.None;
        }

        private void Espessura_ValueChanged(object sender, EventArgs e)
        {
            NunCamadas.Maximum = Espessura.Value;
            Profundidade.Maximum = Espessura.Value;
            Profundidade.Value = Espessura.Value / 2;
        }

        private void Btn_Definir_Click(object sender, EventArgs e)
        {
            if (Profundidade.Value <= 0)
            {
                MessageBox.Show("Nenhuma cota Z foi definida para a profundidade do corte", "Cotas Z", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            USE_COTE_Z = true;
            Z_COTE = (double)Profundidade.Value;

            if (CbHabilitarMulti.Checked && NunCamadas.Value > 0)
            {
                MULTI_LAYERS_ENABLE = true;
                LAYERS_COTE = (double)(Profundidade.Value / NunCamadas.Value);
                LAYERS_COUNT = (int)NunCamadas.Value;
            }

            ExitResult = DialogResult.OK;
            Close();
        }

        private void NunCamadas_ValueChanged(object sender, EventArgs e)
        {
            if (NunCamadas.Value > 0)
            {
                string est = $"{NunCamadas.Value} {(NunCamadas.Value > 1 ? "camadas" : "camada")} de {(Profundidade.Value / NunCamadas.Value):0.000}mm {(NunCamadas.Value > 1 ? "cada" : "")}";
                Estimador.Text = est;
            }
            else
            {
                Estimador.Text = "est.";
            }
        }

        private void CbHabilitarMulti_CheckedChanged(object sender, EventArgs e)
        {
            PainelCamadas.Enabled = CbHabilitarMulti.Checked;
        }
    }
}
