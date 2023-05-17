namespace LaserGRBL.IFMAKER
{
    partial class ZSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZSettings));
            this.Espessura = new System.Windows.Forms.NumericUpDown();
            this.Profundidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Definir = new System.Windows.Forms.Button();
            this.PainelCamadas = new System.Windows.Forms.Panel();
            this.Estimador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NunCamadas = new System.Windows.Forms.NumericUpDown();
            this.CbHabilitarMulti = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Seguranca = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Espessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profundidade)).BeginInit();
            this.PainelCamadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NunCamadas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Espessura
            // 
            this.Espessura.DecimalPlaces = 3;
            this.Espessura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Espessura.Location = new System.Drawing.Point(14, 27);
            this.Espessura.Name = "Espessura";
            this.Espessura.Size = new System.Drawing.Size(148, 20);
            this.Espessura.TabIndex = 0;
            this.Espessura.ValueChanged += new System.EventHandler(this.Espessura_ValueChanged);
            // 
            // Profundidade
            // 
            this.Profundidade.DecimalPlaces = 3;
            this.Profundidade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Profundidade.Location = new System.Drawing.Point(12, 66);
            this.Profundidade.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Profundidade.Name = "Profundidade";
            this.Profundidade.Size = new System.Drawing.Size(148, 20);
            this.Profundidade.TabIndex = 1;
            this.Profundidade.Enter += new System.EventHandler(this.Profundidade_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Espessura da chama em (mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "profundidade de nível (mm)";
            // 
            // Btn_Definir
            // 
            this.Btn_Definir.Location = new System.Drawing.Point(129, 257);
            this.Btn_Definir.Name = "Btn_Definir";
            this.Btn_Definir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Definir.TabIndex = 2;
            this.Btn_Definir.Text = "Definir";
            this.Btn_Definir.UseVisualStyleBackColor = true;
            this.Btn_Definir.Click += new System.EventHandler(this.Btn_Definir_Click);
            // 
            // PainelCamadas
            // 
            this.PainelCamadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelCamadas.Controls.Add(this.Estimador);
            this.PainelCamadas.Controls.Add(this.label4);
            this.PainelCamadas.Controls.Add(this.label3);
            this.PainelCamadas.Controls.Add(this.NunCamadas);
            this.PainelCamadas.Enabled = false;
            this.PainelCamadas.Location = new System.Drawing.Point(13, 143);
            this.PainelCamadas.Name = "PainelCamadas";
            this.PainelCamadas.Size = new System.Drawing.Size(191, 100);
            this.PainelCamadas.TabIndex = 3;
            // 
            // Estimador
            // 
            this.Estimador.AutoSize = true;
            this.Estimador.Location = new System.Drawing.Point(19, 56);
            this.Estimador.Name = "Estimador";
            this.Estimador.Size = new System.Drawing.Size(24, 13);
            this.Estimador.TabIndex = 3;
            this.Estimador.Text = "est.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estimadores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número de camadas";
            // 
            // NunCamadas
            // 
            this.NunCamadas.Location = new System.Drawing.Point(10, 18);
            this.NunCamadas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NunCamadas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NunCamadas.Name = "NunCamadas";
            this.NunCamadas.Size = new System.Drawing.Size(120, 20);
            this.NunCamadas.TabIndex = 0;
            this.NunCamadas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NunCamadas.ValueChanged += new System.EventHandler(this.NunCamadas_ValueChanged);
            // 
            // CbHabilitarMulti
            // 
            this.CbHabilitarMulti.AutoSize = true;
            this.CbHabilitarMulti.Location = new System.Drawing.Point(24, 234);
            this.CbHabilitarMulti.Name = "CbHabilitarMulti";
            this.CbHabilitarMulti.Size = new System.Drawing.Size(135, 17);
            this.CbHabilitarMulti.TabIndex = 4;
            this.CbHabilitarMulti.Text = "Corte em multicamadas";
            this.CbHabilitarMulti.UseVisualStyleBackColor = true;
            this.CbHabilitarMulti.CheckedChanged += new System.EventHandler(this.CbHabilitarMulti_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Seguranca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Espessura);
            this.panel1.Controls.Add(this.Profundidade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 131);
            this.panel1.TabIndex = 5;
            // 
            // Seguranca
            // 
            this.Seguranca.AutoSize = true;
            this.Seguranca.Location = new System.Drawing.Point(12, 92);
            this.Seguranca.Name = "Seguranca";
            this.Seguranca.Size = new System.Drawing.Size(105, 17);
            this.Seguranca.TabIndex = 4;
            this.Seguranca.Text = "Exceder margem";
            this.Seguranca.UseVisualStyleBackColor = true;
            this.Seguranca.CheckedChanged += new System.EventHandler(this.Seguranca_CheckedChanged);
            this.Seguranca.MouseHover += new System.EventHandler(this.Seguranca_MouseHover);
            // 
            // ZSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(217, 289);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CbHabilitarMulti);
            this.Controls.Add(this.PainelCamadas);
            this.Controls.Add(this.Btn_Definir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de profundidade";
            ((System.ComponentModel.ISupportInitialize)(this.Espessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profundidade)).EndInit();
            this.PainelCamadas.ResumeLayout(false);
            this.PainelCamadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NunCamadas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Espessura;
        private System.Windows.Forms.NumericUpDown Profundidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Definir;
        private System.Windows.Forms.Panel PainelCamadas;
        private System.Windows.Forms.CheckBox CbHabilitarMulti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NunCamadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Estimador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Seguranca;
    }
}