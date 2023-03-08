using System.Windows.Forms;

namespace LaserGRBL
{
    public partial class SaveOptionForm : Form
    {
        public SaveOptionForm()
        {
            InitializeComponent();
        }

        internal static void CreateAndShowDialog(Form parent, GrblCore core)
        {
            using (SaveOptionForm f = new SaveOptionForm())
            {
                if (f.ShowDialog(parent) == DialogResult.OK)
                    core.SaveProgram(parent, f.CBHeader.Checked, f.CBFooter.Checked, f.CBBetween.Checked, (int)f.UDCount.Value);
            }
        }

    }
}
