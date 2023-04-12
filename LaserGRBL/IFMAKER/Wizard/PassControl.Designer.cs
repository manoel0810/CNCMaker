namespace LaserGRBL.IFMAKER.Wizard
{
    partial class PassControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_Text
            // 
            this.Lb_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lb_Text.Location = new System.Drawing.Point(2, 6);
            this.Lb_Text.Name = "Lb_Text";
            this.Lb_Text.Size = new System.Drawing.Size(218, 21);
            this.Lb_Text.TabIndex = 0;
            this.Lb_Text.Text = "label1";
            // 
            // PassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lb_Text);
            this.Name = "PassControl";
            this.Size = new System.Drawing.Size(222, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_Text;
    }
}
