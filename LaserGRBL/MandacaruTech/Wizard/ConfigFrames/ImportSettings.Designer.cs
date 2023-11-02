namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    partial class ImportSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_ImportSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportar configurações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Você pode exportar as configurações do GRBL, usando um arquivo de intruções.\r\nSe " +
    "desejar, selecione o arquivo de configurações:";
            // 
            // Btn_ImportSettings
            // 
            this.Btn_ImportSettings.Location = new System.Drawing.Point(459, 314);
            this.Btn_ImportSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ImportSettings.Name = "Btn_ImportSettings";
            this.Btn_ImportSettings.Size = new System.Drawing.Size(237, 48);
            this.Btn_ImportSettings.TabIndex = 2;
            this.Btn_ImportSettings.Text = "Buscar arquivo";
            this.Btn_ImportSettings.UseVisualStyleBackColor = true;
            this.Btn_ImportSettings.Click += new System.EventHandler(this.Btn_ImportSettings_Click);
            // 
            // ImportSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(804, 665);
            this.Controls.Add(this.Btn_ImportSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImportSettings";
            this.Text = "ImportSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_ImportSettings;
    }
}