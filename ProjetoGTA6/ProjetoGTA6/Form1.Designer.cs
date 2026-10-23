namespace ProjetoGTA6
{
    partial class FrmDashboard
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.PrgMundoAberto = new System.Windows.Forms.ProgressBar();
            this.LblMotorGrafico = new System.Windows.Forms.Label();
            this.PrgMotorGrafico = new System.Windows.Forms.ProgressBar();
            this.PrgServidores = new System.Windows.Forms.ProgressBar();
            this.LblMundoAberto = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblServidores = new System.Windows.Forms.Label();
            this.GrpStatusSistema = new System.Windows.Forms.GroupBox();
            this.BtnCarregarMapas = new System.Windows.Forms.Button();
            this.BtnSimularConexao = new System.Windows.Forms.Button();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.TxtLogNoticias = new System.Windows.Forms.TextBox();
            this.GrpStatusSistemas = new System.Windows.Forms.GroupBox();
            this.GrpStatusSistema.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.GrpStatusSistemas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrgMundoAberto
            // 
            this.PrgMundoAberto.Location = new System.Drawing.Point(27, 137);
            this.PrgMundoAberto.Name = "PrgMundoAberto";
            this.PrgMundoAberto.Size = new System.Drawing.Size(168, 23);
            this.PrgMundoAberto.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PrgMundoAberto.TabIndex = 3;
            this.PrgMundoAberto.Value = 50;
            // 
            // LblMotorGrafico
            // 
            this.LblMotorGrafico.AutoSize = true;
            this.LblMotorGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotorGrafico.Location = new System.Drawing.Point(241, 34);
            this.LblMotorGrafico.Name = "LblMotorGrafico";
            this.LblMotorGrafico.Size = new System.Drawing.Size(145, 15);
            this.LblMotorGrafico.TabIndex = 6;
            this.LblMotorGrafico.Text = "Motor Gráfico (RAGE 9.0)";
            // 
            // PrgMotorGrafico
            // 
            this.PrgMotorGrafico.Location = new System.Drawing.Point(234, 58);
            this.PrgMotorGrafico.Name = "PrgMotorGrafico";
            this.PrgMotorGrafico.Size = new System.Drawing.Size(168, 23);
            this.PrgMotorGrafico.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PrgMotorGrafico.TabIndex = 4;
            this.PrgMotorGrafico.Value = 65;
            // 
            // PrgServidores
            // 
            this.PrgServidores.Location = new System.Drawing.Point(27, 58);
            this.PrgServidores.Name = "PrgServidores";
            this.PrgServidores.Size = new System.Drawing.Size(168, 23);
            this.PrgServidores.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PrgServidores.TabIndex = 2;
            this.PrgServidores.Value = 50;
            // 
            // LblMundoAberto
            // 
            this.LblMundoAberto.AutoSize = true;
            this.LblMundoAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMundoAberto.Location = new System.Drawing.Point(31, 116);
            this.LblMundoAberto.Name = "LblMundoAberto";
            this.LblMundoAberto.Size = new System.Drawing.Size(140, 15);
            this.LblMundoAberto.TabIndex = 7;
            this.LblMundoAberto.Text = "Mundo Aberto (Vice City)";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.HotPink;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1281, 64);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "PAINEL DE CONTROLE - LEONIDA";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblServidores
            // 
            this.LblServidores.AutoSize = true;
            this.LblServidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServidores.Location = new System.Drawing.Point(31, 34);
            this.LblServidores.Name = "LblServidores";
            this.LblServidores.Size = new System.Drawing.Size(164, 15);
            this.LblServidores.TabIndex = 5;
            this.LblServidores.Text = "Servidor Online (Ping: 34ms)";
            this.LblServidores.Click += new System.EventHandler(this.label2_Click);
            // 
            // GrpStatusSistema
            // 
            this.GrpStatusSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpStatusSistema.BackColor = System.Drawing.Color.Black;
            this.GrpStatusSistema.Controls.Add(this.BtnCarregarMapas);
            this.GrpStatusSistema.Controls.Add(this.BtnSimularConexao);
            this.GrpStatusSistema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpStatusSistema.ForeColor = System.Drawing.Color.HotPink;
            this.GrpStatusSistema.Location = new System.Drawing.Point(1046, 87);
            this.GrpStatusSistema.Name = "GrpStatusSistema";
            this.GrpStatusSistema.Size = new System.Drawing.Size(247, 231);
            this.GrpStatusSistema.TabIndex = 8;
            this.GrpStatusSistema.TabStop = false;
            this.GrpStatusSistema.Text = "PROTOCOLO DE DEPURAÇÃO";
            // 
            // BtnCarregarMapas
            // 
            this.BtnCarregarMapas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCarregarMapas.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.BtnCarregarMapas.FlatAppearance.BorderSize = 2;
            this.BtnCarregarMapas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnCarregarMapas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCarregarMapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarregarMapas.Location = new System.Drawing.Point(60, 137);
            this.BtnCarregarMapas.Name = "BtnCarregarMapas";
            this.BtnCarregarMapas.Size = new System.Drawing.Size(140, 33);
            this.BtnCarregarMapas.TabIndex = 1;
            this.BtnCarregarMapas.Text = "Carregar Mapas";
            this.BtnCarregarMapas.UseVisualStyleBackColor = true;
            this.BtnCarregarMapas.Click += new System.EventHandler(this.BtnCarregarAssets_Click);
            // 
            // BtnSimularConexao
            // 
            this.BtnSimularConexao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSimularConexao.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.BtnSimularConexao.FlatAppearance.BorderSize = 2;
            this.BtnSimularConexao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BtnSimularConexao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSimularConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimularConexao.Location = new System.Drawing.Point(60, 58);
            this.BtnSimularConexao.Name = "BtnSimularConexao";
            this.BtnSimularConexao.Size = new System.Drawing.Size(140, 34);
            this.BtnSimularConexao.TabIndex = 0;
            this.BtnSimularConexao.Text = "Simular Conexão";
            this.BtnSimularConexao.UseVisualStyleBackColor = true;
            this.BtnSimularConexao.Click += new System.EventHandler(this.BtnSimularConexao_Click);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlHeader.BackgroundImage")));
            this.PnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnlHeader.Controls.Add(this.TxtLogNoticias);
            this.PnlHeader.Controls.Add(this.GrpStatusSistemas);
            this.PnlHeader.Controls.Add(this.GrpStatusSistema);
            this.PnlHeader.Controls.Add(this.LblTitulo);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1305, 626);
            this.PnlHeader.TabIndex = 9;
            // 
            // TxtLogNoticias
            // 
            this.TxtLogNoticias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.TxtLogNoticias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogNoticias.ForeColor = System.Drawing.Color.SpringGreen;
            this.TxtLogNoticias.Location = new System.Drawing.Point(0, 495);
            this.TxtLogNoticias.Multiline = true;
            this.TxtLogNoticias.Name = "TxtLogNoticias";
            this.TxtLogNoticias.ReadOnly = true;
            this.TxtLogNoticias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLogNoticias.Size = new System.Drawing.Size(1305, 131);
            this.TxtLogNoticias.TabIndex = 10;
            this.TxtLogNoticias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLogNoticias.Visible = false;
            this.TxtLogNoticias.TextChanged += new System.EventHandler(this.TxtLogNoticias_TextChanged);
            // 
            // GrpStatusSistemas
            // 
            this.GrpStatusSistemas.Controls.Add(this.PrgServidores);
            this.GrpStatusSistemas.Controls.Add(this.LblServidores);
            this.GrpStatusSistemas.Controls.Add(this.LblMotorGrafico);
            this.GrpStatusSistemas.Controls.Add(this.PrgMundoAberto);
            this.GrpStatusSistemas.Controls.Add(this.LblMundoAberto);
            this.GrpStatusSistemas.Controls.Add(this.PrgMotorGrafico);
            this.GrpStatusSistemas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpStatusSistemas.ForeColor = System.Drawing.Color.HotPink;
            this.GrpStatusSistemas.Location = new System.Drawing.Point(12, 87);
            this.GrpStatusSistemas.Name = "GrpStatusSistemas";
            this.GrpStatusSistemas.Size = new System.Drawing.Size(478, 234);
            this.GrpStatusSistemas.TabIndex = 9;
            this.GrpStatusSistemas.TabStop = false;
            this.GrpStatusSistemas.Text = "Status Sistemas";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1305, 626);
            this.Controls.Add(this.PnlHeader);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashboard";
            this.Text = "Painel de Controle - Leonida";
            this.GrpStatusSistema.ResumeLayout(false);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.GrpStatusSistemas.ResumeLayout(false);
            this.GrpStatusSistemas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PrgMundoAberto;
        private System.Windows.Forms.Label LblMotorGrafico;
        private System.Windows.Forms.ProgressBar PrgMotorGrafico;
        private System.Windows.Forms.ProgressBar PrgServidores;
        private System.Windows.Forms.Label LblMundoAberto;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblServidores;
        private System.Windows.Forms.GroupBox GrpStatusSistema;
        private System.Windows.Forms.Button BtnCarregarMapas;
        private System.Windows.Forms.Button BtnSimularConexao;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.GroupBox GrpStatusSistemas;
        private System.Windows.Forms.TextBox TxtLogNoticias;
    }
}

