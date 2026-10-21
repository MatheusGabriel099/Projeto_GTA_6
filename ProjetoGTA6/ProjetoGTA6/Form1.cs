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
            // Adiciona uma nova linha de texto ao console informando que o teste de estresse dos servidores começou.
            TxtLogNoticias.AppendText(Environment.NewLine + "[NET] Iniciando teste de estresse nos servidores da Rockstar Games...");

            //Define que o menor valor possível para a barra dos servidores é 0.
            PrgServidores.Minimum = 0;
            PrgMotorGrafico.Minimum = 0;
            PrgMundoAberto.Minimum = 0;

            // Define que o valor máximo de limite para a barra dos servidores é 100.
            PrgServidores.Maximum = 100;
            PrgMotorGrafico.Maximum = 100;
            PrgMundoAberto.Maximum = 100;

            // Zera completamente o preenchimento da barra dos servidores antes de iniciar a animação.
            PrgServidores.Value = 0;
            PrgMotorGrafico.Value = 0;
            PrgMundoAberto.Value = 0;


            // Loop que faz a barra encher até 100% durante a simulação
            for (int i = 0; i <= 100; i++)
            {
                //Modifica o preenchimento da barra para subir junto com o contador.
                PrgServidores.Value = i;
                PrgMotorGrafico.Value = i;
                PrgMundoAberto.Value = i;

                // Força a pintar o novo preenchimento da barra dos servidores na tela na mesma hora.
                PrgServidores.Refresh();
                PrgMotorGrafico.Refresh();
                PrgMundoAberto.Refresh();

                //Gera uma mini pausa de 10 milissegundos.
                System.Threading.Thread.Sleep(10);
            }

            TxtLogNoticias.AppendText(Environment.NewLine + "[SUCCESS] Pacotes de rede sincronizados. Latência estável em 34ms.");

            // Abre a mensagem na tela (O código "para" aqui até você fechar)
            MessageBox.Show("Sistemas simulados e sincronizados com sucesso!", "Painel Leonida");

            // Reseta os valores das ProgressBars para o padrão inicial da imagem
            PrgServidores.Value = 50; // Servidor Online volta para 50%
            PrgMotorGrafico.Value = 65; // Motor Gráfico volta para 65%
            PrgMundoAberto.Value = 50; // Mundo Aberto volta para 50%

            // Adiciona um aviso no painel de controle confirmando o reset
            TxtLogNoticias.AppendText(Environment.NewLine + "[SYSTEM] Simulação finalizada. Valores retornados ao padrão de telemetria.");
        }

        private void BtnCarregarAssets_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a Tela Principal

            using (FrmLeonida telaMapa = new FrmLeonida()) // Abre a tela Mapas por cima
            {
                telaMapa.ShowDialog(); // Abre a tela Mapas
            }

            this.Show(); // Quando o usuário clicar no botão "Voltar", o mapa trazendo a tela principal                   
        }

        private void TxtLogNoticias_TextChanged(object sender, EventArgs e)
        {
            TxtLogNoticias.BackColor = Color.FromArgb(20, 20, 28); // Fundo escuro
            TxtLogNoticias.ForeColor = Color.FromArgb(0, 255, 127); // Letras verdes
            TxtLogNoticias.Font = new Font("Consolas", 10); //Altera o estilo do texto do console de logs para a fonte Consolas, tamanho 10.
            TxtLogNoticias.Dock = DockStyle.Bottom; // COLA E ALINHA NO RODAPÉ SOZINHO!
            TxtLogNoticias.Height = 130; // Altura do console
        }
    }

}
