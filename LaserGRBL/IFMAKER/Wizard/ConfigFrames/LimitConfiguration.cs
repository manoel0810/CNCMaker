using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    public partial class LimitConfiguration : Form
    {
        private string Config;

        public LimitConfiguration(string Configurations)
        {
            InitializeComponent();
            Config = Configurations;
        }
    }
}
