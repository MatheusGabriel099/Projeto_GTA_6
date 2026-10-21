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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeonida));
            this.TxtDetalhesDistrito = new System.Windows.Forms.TextBox();
            this.PicMapa = new System.Windows.Forms.PictureBox();
            this.Gpb_Botoes = new System.Windows.Forms.GroupBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.RdbViceBeaches = new System.Windows.Forms.RadioButton();
            this.RdbLeonidaRural = new System.Windows.Forms.RadioButton();
            this.RdbViceCity = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PicMapa)).BeginInit();
            this.Gpb_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDetalhesDistrito
            // 
            this.TxtDetalhesDistrito.BackColor = System.Drawing.Color.Black;
            this.TxtDetalhesDistrito.Enabled = false;
            this.TxtDetalhesDistrito.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDetalhesDistrito.ForeColor = System.Drawing.Color.HotPink;
            this.TxtDetalhesDistrito.Location = new System.Drawing.Point(1070, 212);
            this.TxtDetalhesDistrito.Multiline = true;
            this.TxtDetalhesDistrito.Name = "TxtDetalhesDistrito";
            this.TxtDetalhesDistrito.ReadOnly = true;
            this.TxtDetalhesDistrito.Size = new System.Drawing.Size(223, 341);
            this.TxtDetalhesDistrito.TabIndex = 1;
            this.TxtDetalhesDistrito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PicMapa
            // 
            this.PicMapa.BackColor = System.Drawing.Color.Transparent;
            this.PicMapa.Location = new System.Drawing.Point(12, 12);
            this.PicMapa.Name = "PicMapa";
            this.PicMapa.Size = new System.Drawing.Size(1052, 541);
            this.PicMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMapa.TabIndex = 2;
            this.PicMapa.TabStop = false;
            // 
            // Gpb_Botoes
            // 
            this.Gpb_Botoes.Controls.Add(this.BtnVoltar);
            this.Gpb_Botoes.Controls.Add(this.RdbViceBeaches);
            this.Gpb_Botoes.Controls.Add(this.RdbLeonidaRural);
            this.Gpb_Botoes.Controls.Add(this.RdbViceCity);
            this.Gpb_Botoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Botoes.ForeColor = System.Drawing.Color.HotPink;
            this.Gpb_Botoes.Location = new System.Drawing.Point(1070, 12);
            this.Gpb_Botoes.Name = "Gpb_Botoes";
            this.Gpb_Botoes.Size = new System.Drawing.Size(223, 194);
            this.Gpb_Botoes.TabIndex = 3;
            this.Gpb_Botoes.TabStop = false;
            this.Gpb_Botoes.Text = "Botões";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.BtnVoltar.FlatAppearance.BorderSize = 2;
            this.BtnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BtnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Location = new System.Drawing.Point(40, 144);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(140, 30);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar ao Painel";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // RdbViceBeaches
            // 
            this.RdbViceBeaches.AutoSize = true;
            this.RdbViceBeaches.ForeColor = System.Drawing.Color.HotPink;
            this.RdbViceBeaches.Location = new System.Drawing.Point(7, 102);
            this.RdbViceBeaches.Name = "RdbViceBeaches";
            this.RdbViceBeaches.Size = new System.Drawing.Size(117, 24);
            this.RdbViceBeaches.TabIndex = 2;
            this.RdbViceBeaches.Text = "Vice Beaches";
            this.RdbViceBeaches.UseVisualStyleBackColor = true;
            this.RdbViceBeaches.CheckedChanged += new System.EventHandler(this.RdbViceBeaches_CheckedChanged);
            // 
            // RdbLeonidaRural
            // 
            this.RdbLeonidaRural.AutoSize = true;
            this.RdbLeonidaRural.ForeColor = System.Drawing.Color.HotPink;
            this.RdbLeonidaRural.Location = new System.Drawing.Point(7, 71);
            this.RdbLeonidaRural.Name = "RdbLeonidaRural";
            this.RdbLeonidaRural.Size = new System.Drawing.Size(123, 24);
            this.RdbLeonidaRural.TabIndex = 1;
            this.RdbLeonidaRural.Text = "Leonida Rural";
            this.RdbLeonidaRural.UseVisualStyleBackColor = true;
            this.RdbLeonidaRural.CheckedChanged += new System.EventHandler(this.RdbLeonidaRural_CheckedChanged);
            // 
            // RdbViceCity
            // 
            this.RdbViceCity.AutoSize = true;
            this.RdbViceCity.ForeColor = System.Drawing.Color.HotPink;
            this.RdbViceCity.Location = new System.Drawing.Point(7, 40);
            this.RdbViceCity.Name = "RdbViceCity";
            this.RdbViceCity.Size = new System.Drawing.Size(87, 24);
            this.RdbViceCity.TabIndex = 0;
            this.RdbViceCity.Text = "Vice City";
            this.RdbViceCity.UseVisualStyleBackColor = true;
            this.RdbViceCity.CheckedChanged += new System.EventHandler(this.RdbViceCity_CheckedChanged);
            // 
            // FrmLeonida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ProjetoGTA6.Properties.Resources.gta6logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1305, 626);
            this.Controls.Add(this.Gpb_Botoes);
            this.Controls.Add(this.PicMapa);
            this.Controls.Add(this.TxtDetalhesDistrito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLeonida";
            this.Text = "Mapas";
            this.Load += new System.EventHandler(this.FrmLeonida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicMapa)).EndInit();
            this.Gpb_Botoes.ResumeLayout(false);
            this.Gpb_Botoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDetalhesDistrito;
        private System.Windows.Forms.PictureBox PicMapa;
        private System.Windows.Forms.GroupBox Gpb_Botoes;
        private System.Windows.Forms.RadioButton RdbViceBeaches;
        private System.Windows.Forms.RadioButton RdbLeonidaRural;
        private System.Windows.Forms.RadioButton RdbViceCity;
        private System.Windows.Forms.Button BtnVoltar;
    }
}