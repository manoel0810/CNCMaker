﻿using System;
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
    public partial class ImportSettings : Form
    {
        private string Config;

        public ImportSettings(string Configurations)
        {
            InitializeComponent();
            Config = Configurations;
        }
    }
}
