using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoGTA6
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSimularConexao_Click(object sender, EventArgs e)
        {

            TxtLogNoticias.AppendText(Environment.NewLine + "[NET] Iniciando teste de estresse nos servidores da Rockstar Games...");

            PrgServidores.Minimum = 0;
            PrgServidores.Maximum = 100;
            PrgServidores.Value = 0;

            // 1. Loop que faz a barra encher até 100% durante a simulação
            for (int i = 0; i <= 100; i++)
            {
                PrgServidores.Value = i;
                PrgServidores.Refresh();
                System.Threading.Thread.Sleep(10);
            }

            TxtLogNoticias.AppendText(Environment.NewLine + "[SUCCESS] Pacotes de rede sincronizados. Latência estável em 34ms.");

            // 2. Abre a mensagem na tela (O código "para" aqui até você fechar)
            MessageBox.Show("Sistemas simulados e sincronizados com sucesso!", "Painel Leonida");

            // =========================================================================
            // TRUQUE: As linhas abaixo só executam DEPOIS que você fecha o MessageBox!
            // =========================================================================

            // 3. Reseta os valores das ProgressBars para o padrão inicial da imagem
            PrgServidores.Value = 50;       // Servidor Online volta para 50%
            PrgMotorGrafico.Value = 65;     // Motor Gráfico volta para 65%
            PrgMundoAberto.Value = 50;      // Mundo Aberto volta para 50%

            // 4. Adiciona um aviso no painel de controle confirmando o reset
            TxtLogNoticias.AppendText(Environment.NewLine + "[SYSTEM] Simulação finalizada. Valores retornados ao padrão de telemetria.");
        }

        private void BtnCarregarAssets_Click(object sender, EventArgs e)
        {
            using (FrmLeonida telaMapa = new FrmLeonida())
            {
                telaMapa.ShowDialog(); // Abre como uma janela bloqueante (foca nela)
            }
        }

        private void TxtLogNoticias_TextChanged(object sender, EventArgs e)
        {
            TxtLogNoticias.BackColor = Color.FromArgb(20, 20, 28); // Fundo escuro
            TxtLogNoticias.ForeColor = Color.FromArgb(0, 255, 127); // Letras verdes
            TxtLogNoticias.Font = new Font("Consolas", 10);
            TxtLogNoticias.Dock = DockStyle.Bottom; // COLA E ALINHA NO RODAPÉ SOZINHO!
            TxtLogNoticias.Height = 120; // Altura do console
        }
    }

}
