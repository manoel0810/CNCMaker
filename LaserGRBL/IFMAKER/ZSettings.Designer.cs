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
            ((System.ComponentModel.ISupportInitialize)(this.Espessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profundidade)).BeginInit();
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
            this.Espessura.Location = new System.Drawing.Point(30, 29);
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
            this.Profundidade.Location = new System.Drawing.Point(31, 72);
            this.Profundidade.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Profundidade.Name = "Profundidade";
            this.Profundidade.Size = new System.Drawing.Size(148, 20);
            this.Profundidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Espessura da chama em (mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "profundidade de nível (mm)";
            // 
            // Btn_Definir
            // 
            this.Btn_Definir.Location = new System.Drawing.Point(103, 114);
            this.Btn_Definir.Name = "Btn_Definir";
            this.Btn_Definir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Definir.TabIndex = 2;
            this.Btn_Definir.Text = "Definir";
            this.Btn_Definir.UseVisualStyleBackColor = true;
            this.Btn_Definir.Click += new System.EventHandler(this.Btn_Definir_Click);
            // 
            // ZSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(208, 150);
            this.Controls.Add(this.Btn_Definir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Profundidade);
            this.Controls.Add(this.Espessura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de profundidade";
            ((System.ComponentModel.ISupportInitialize)(this.Espessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profundidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Espessura;
        private System.Windows.Forms.NumericUpDown Profundidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Definir;
    }
}