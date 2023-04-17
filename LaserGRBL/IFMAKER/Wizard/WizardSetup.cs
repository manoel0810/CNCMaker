using LaserGRBL.IFMAKER.Wizard.ConfigFrames;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaserGRBL.IFMAKER.Wizard
{
    public partial class WizardSetup : Form
    {
        private readonly Formularios[] Formns;
        private int Index = -1;
        private string[] FormatedCommandString = new string[0];
        private readonly GrblCore mCore;

        public WizardSetup(GrblCore mCore)
        {
            InitializeComponent();
            CheckConnection.Start();
            ReadCommands();

            Formns = new Formularios[]
            {
               new Formularios(0, "1.   Importar Configurações", new PassControl(), new ImportSettings(mCore)),
               new Formularios(1, "2.   Teste de direção", new PassControl(), new DirectionTest(FormatedCommandString, mCore)),
               new Formularios(2, "3.   Calibragem de passo", new PassControl(), new CalibrationForm(FormatedCommandString, mCore)),
               new Formularios(3, "4.   Configuração de limite", new PassControl(), new LimitConfiguration(FormatedCommandString, mCore)),
               new Formularios(4, "5.   Homing", new PassControl(), new HomingConfiguration(FormatedCommandString, mCore))
            };

            this.mCore = mCore;
        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            if (Index <= 0)
                return;

            DrawPass(--Index);
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (Index == (Formns.Length - 1))
            {
                Close();
                return;
            }

            DrawPass(++Index);
        }

        private void WizardSetup_Load(object sender, EventArgs e)
        {
            foreach (var item in Formns)
                item.Control.SetProperties(new Font("Arial", 8f, FontStyle.Regular), item.Description);

            //Inicia na primeira tela de configurações
            DrawPass(++Index);
        }

        private void DrawPass(int Index)
        {
            if (Index > (Formns.Length - 1))
                return;

            for (int i = 0; i < Formns.Length; i++)
            {
                if (i == Index)
                {
                    var obj = Formns[Index].Control; obj.SetProperties(new Font("Arial", 8f, FontStyle.Bold), Formns[Index].Description);
                    Formns[i].Control = obj;

                }
                else
                {
                    var obj = Formns[i].Control; obj.SetProperties(new Font("Arial", 8f, FontStyle.Regular), Formns[i].Description);
                    Formns[i].Control = obj;
                }
            }


            if (Index > 0 && !Btn_Last.Enabled)
                Btn_Last.Enabled = true;
            else if (Index < (Formns.Length - 1) /*&& !Btn_Next.Enabled*/)
            {
                Btn_Next.Text = "Próximo";
                //Btn_Next.Enabled = true;
            }


            if (Index == 0)
                Btn_Last.Enabled = false;
            else if (Index == (Formns.Length - 1))
            {
                Btn_Next.Text = "Concluir";
                //Btn_Next.Enabled = false;
            }


            UpdateList();
            ChangeForm(Index);
        }

        private void UpdateList()
        {
            SuspendLayout();
            Itens.Controls.Clear();

            foreach (var item in Formns)
                Itens.Controls.Add(item.Control);

            ResumeLayout();
        }

        private void ChangeForm(int Index)
        {
            if (PainelOps.Controls.Count > 0)
                PainelOps.Controls.Clear();

            Form NF = Formns[Index].Formulario;
            NF.TopLevel = false;
            NF.Dock = DockStyle.Fill;

            if (PainelOps.Controls.Count > 0x0)
                PainelOps.Controls.RemoveAt(0x0);

            PainelOps.Controls.Add(NF);
            PainelOps.Tag = NF;
            NF.Show(); PainelOps.Refresh();
        }

        private void ReadCommands()
        {
            var config = GrblCore.Configuration.ToList();
            string s = "";
            foreach (var c in config)
                s += $"{c.DollarNumber}={c.Value}%";

            FormatedCommandString = s.Split('%');
        }

        private sealed class Formularios
        {
            public int Index { get; set; }
            public string Description { get; set; }
            public PassControl Control { get; set; }
            public Form Formulario { get; set; }

            public Formularios()
            {

            }

            public Formularios(int Index, string Description, PassControl Control)
            {
                this.Index = Index;
                this.Description = Description;
                this.Control = Control;
            }

            public Formularios(int Index, string Description, PassControl Control, Form Formulario)
            {
                this.Index = Index;
                this.Description = Description;
                this.Control = Control;
                this.Formulario = Formulario;
            }
        }

        private void CheckConnection_Tick(object sender, EventArgs e)
        {
            if (mCore.MachineStatus != GrblCore.MacStatus.Idle)
            {
                PainelOps.Enabled = false;
                Btn_Next.Enabled = false;
                Btn_Last.Enabled = false;
            }
            else
            {
                if (PainelOps.Enabled == false)
                {
                    PainelOps.Enabled = true;
                    Btn_Next.Enabled = true;
                    Btn_Last.Enabled = true;
                }
            }
        }
    }
}
