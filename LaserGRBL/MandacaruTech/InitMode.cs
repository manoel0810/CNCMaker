using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER
{
    public partial class InitMode : Form
    {
        private static WorkMode _ActualWorkMode = WorkMode.Laser;
        public static WorkMode ActualWorkMode => _ActualWorkMode;

        private readonly Dictionary<RadioButton, WorkMode> Map = null;
        private ToolTip toolTip;

        private void DefautFunctionRadioButton(object sender, string message)
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip((RadioButton)sender, message);
        }

        private void DefineHouverEvents(RadioButton radioButton, string message)
        {
            radioButton.MouseHover += (obj, args) =>
            {
                DefautFunctionRadioButton(obj, message);
            };
        }

        public InitMode()
        {
            InitializeComponent();
            Map = new Dictionary<RadioButton, WorkMode>()
            {
                { LaserMode, WorkMode.Laser },
                { RouterMode, WorkMode.Router },
                { RecorteMode, WorkMode.Recorte }
            };

            DefineHouverEvents(LaserMode, "Define o progama para operar no modo laser");
            DefineHouverEvents(RouterMode, "Define o progama para operar no modo router (fresa)");
            DefineHouverEvents(RecorteMode, "Define o progama para operar no modo de recorte (lâmina)");

            LaserMode.Checked = true;
            RouterMode.Checked = false;
            RecorteMode.Checked = false;
        }

        private void InitMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void InitMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (KeyValuePair<RadioButton, WorkMode> mapped in Map)
            {
                if (mapped.Key.Checked)
                {
                    _ActualWorkMode = mapped.Value;
                    break;
                }
            }
        }
    }

    public enum WorkMode : int
    {
        Laser,
        Router,
        Recorte
    }
}
