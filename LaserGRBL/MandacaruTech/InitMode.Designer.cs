namespace LaserGRBL.IFMAKER
{
    partial class InitMode
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
            this.LaserMode = new System.Windows.Forms.RadioButton();
            this.RouterMode = new System.Windows.Forms.RadioButton();
            this.RecorteMode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LaserMode
            // 
            this.LaserMode.AutoSize = true;
            this.LaserMode.Location = new System.Drawing.Point(28, 33);
            this.LaserMode.Name = "LaserMode";
            this.LaserMode.Size = new System.Drawing.Size(51, 17);
            this.LaserMode.TabIndex = 0;
            this.LaserMode.Text = "Laser";
            this.LaserMode.UseVisualStyleBackColor = true;
            // 
            // RouterMode
            // 
            this.RouterMode.AutoSize = true;
            this.RouterMode.Location = new System.Drawing.Point(85, 33);
            this.RouterMode.Name = "RouterMode";
            this.RouterMode.Size = new System.Drawing.Size(57, 17);
            this.RouterMode.TabIndex = 0;
            this.RouterMode.TabStop = true;
            this.RouterMode.Text = "Router";
            this.RouterMode.UseVisualStyleBackColor = true;
            // 
            // RecorteMode
            // 
            this.RecorteMode.AutoSize = true;
            this.RecorteMode.Location = new System.Drawing.Point(148, 33);
            this.RecorteMode.Name = "RecorteMode";
            this.RecorteMode.Size = new System.Drawing.Size(63, 17);
            this.RecorteMode.TabIndex = 0;
            this.RecorteMode.TabStop = true;
            this.RecorteMode.Text = "Recorte";
            this.RecorteMode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modos disponíveis:";
            // 
            // InitMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(236, 67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecorteMode);
            this.Controls.Add(this.RouterMode);
            this.Controls.Add(this.LaserMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitMode";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definir modo de operação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitMode_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InitMode_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton LaserMode;
        private System.Windows.Forms.RadioButton RouterMode;
        private System.Windows.Forms.RadioButton RecorteMode;
        private System.Windows.Forms.Label label1;
    }
}