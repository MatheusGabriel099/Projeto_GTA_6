namespace ProjetoGTA6
{
    partial class FrmLeonida
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
            this.CboDistritos = new System.Windows.Forms.ComboBox();
            this.TxtDetalhesDistrito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CboDistritos
            // 
            this.CboDistritos.FormattingEnabled = true;
            this.CboDistritos.Location = new System.Drawing.Point(1039, 41);
            this.CboDistritos.Name = "CboDistritos";
            this.CboDistritos.Size = new System.Drawing.Size(254, 21);
            this.CboDistritos.TabIndex = 0;
            this.CboDistritos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtDetalhesDistrito
            // 
            this.TxtDetalhesDistrito.Location = new System.Drawing.Point(1039, 95);
            this.TxtDetalhesDistrito.Multiline = true;
            this.TxtDetalhesDistrito.Name = "TxtDetalhesDistrito";
            this.TxtDetalhesDistrito.Size = new System.Drawing.Size(254, 366);
            this.TxtDetalhesDistrito.TabIndex = 1;
            // 
            // FrmLeonida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 626);
            this.Controls.Add(this.TxtDetalhesDistrito);
            this.Controls.Add(this.CboDistritos);
            this.Name = "FrmLeonida";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmLeonida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboDistritos;
        private System.Windows.Forms.TextBox TxtDetalhesDistrito;
    }
}