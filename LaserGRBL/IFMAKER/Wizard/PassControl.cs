using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard
{
    public partial class PassControl : UserControl
    {
        public PassControl()
        {
            InitializeComponent();
        }

        public PassControl(Font F, string s)
        {
            SetFont(F);
            SetText(s);
        }

        public void SetFont(Font F)
        {
            Lb_Text.Font = F;
        }

        public void SetText(string Text)
        {
            Lb_Text.Text = Text;
        }

        public void SetProperties(Font F, string Text)
        {
            SetFont(F);
            SetText(Text);
        }

        public string GetText() { return Lb_Text.Text;  }
    }
}
