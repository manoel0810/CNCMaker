namespace LaserGRBL.IFMAKER.Wizard
{
    partial class WizardSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardSetup));
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Last = new System.Windows.Forms.Button();
            this.PainelOps = new System.Windows.Forms.Panel();
            this.Itens = new System.Windows.Forms.FlowLayoutPanel();
            this.Pb_Header = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckConnection = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Next
            // 
            this.Btn_Next.Location = new System.Drawing.Point(1029, 666);
            this.Btn_Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(112, 35);
            this.Btn_Next.TabIndex = 2;
            this.Btn_Next.Text = "Próximo";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Last
            // 
            this.Btn_Last.Location = new System.Drawing.Point(907, 666);
            this.Btn_Last.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.Size = new System.Drawing.Size(112, 35);
            this.Btn_Last.TabIndex = 2;
            this.Btn_Last.Text = "Anterior";
            this.Btn_Last.UseVisualStyleBackColor = true;
            this.Btn_Last.Click += new System.EventHandler(this.Btn_Last_Click);
            // 
            // PainelOps
            // 
            this.PainelOps.BackColor = System.Drawing.Color.Lavender;
            this.PainelOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelOps.Location = new System.Drawing.Point(342, 0);
            this.PainelOps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PainelOps.Name = "PainelOps";
            this.PainelOps.Size = new System.Drawing.Size(803, 664);
            this.PainelOps.TabIndex = 3;
            // 
            // Itens
            // 
            this.Itens.Location = new System.Drawing.Point(2, 86);
            this.Itens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Itens.Name = "Itens";
            this.Itens.Size = new System.Drawing.Size(326, 423);
            this.Itens.TabIndex = 4;
            // 
            // Pb_Header
            // 
            this.Pb_Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_Header.BackgroundImage")));
            this.Pb_Header.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Header.Image")));
            this.Pb_Header.Location = new System.Drawing.Point(3, 6);
            this.Pb_Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pb_Header.Name = "Pb_Header";
            this.Pb_Header.Size = new System.Drawing.Size(298, 77);
            this.Pb_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Header.TabIndex = 5;
            this.Pb_Header.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 538);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Itens);
            this.panel1.Controls.Add(this.Pb_Header);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 664);
            this.panel1.TabIndex = 0;
            // 
            // CheckConnection
            // 
            this.CheckConnection.Enabled = true;
            this.CheckConnection.Interval = 200;
            this.CheckConnection.Tick += new System.EventHandler(this.CheckConnection_Tick);
            // 
            // WizardSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PainelOps);
            this.Controls.Add(this.Btn_Last);
            this.Controls.Add(this.Btn_Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WizardSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WizardSetup";
            this.Load += new System.EventHandler(this.WizardSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Last;
        private System.Windows.Forms.Panel PainelOps;
        private System.Windows.Forms.FlowLayoutPanel Itens;
        private System.Windows.Forms.PictureBox Pb_Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer CheckConnection;
    }
}