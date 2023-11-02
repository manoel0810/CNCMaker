﻿namespace LaserGRBL.IFMAKER.Wizard.ConfigFrames
{
    partial class HomingConfiguration
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
            this.CB_HommingEnable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_HommingEnable
            // 
            this.CB_HommingEnable.AutoSize = true;
            this.CB_HommingEnable.Location = new System.Drawing.Point(23, 211);
            this.CB_HommingEnable.Name = "CB_HommingEnable";
            this.CB_HommingEnable.Size = new System.Drawing.Size(148, 17);
            this.CB_HommingEnable.TabIndex = 9;
            this.CB_HommingEnable.Text = "Habilitar a função Homing";
            this.CB_HommingEnable.UseVisualStyleBackColor = true;
            this.CB_HommingEnable.Click += new System.EventHandler(this.CB_EnableHomming_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ative/desative a caixa de confirmação para este recurso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Homing é um processo em que a máquina CNC retorna à sua posição de referência, es" +
    "tabelecendo uma \r\nbase para os movimentos futuros.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Habilitar/Desabilitar Homing";
            // 
            // LBWarning
            // 
            this.LBWarning.AutoSize = true;
            this.LBWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBWarning.Location = new System.Drawing.Point(20, 231);
            this.LBWarning.Name = "LBWarning";
            this.LBWarning.Size = new System.Drawing.Size(270, 13);
            this.LBWarning.TabIndex = 10;
            this.LBWarning.Text = "Atenção: Esta função requer fim de curso nos três eixos";
            this.LBWarning.Visible = false;
            // 
            // HomingConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(536, 432);
            this.Controls.Add(this.LBWarning);
            this.Controls.Add(this.CB_HommingEnable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomingConfiguration";
            this.Text = "HomingConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_HommingEnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBWarning;
    }
}