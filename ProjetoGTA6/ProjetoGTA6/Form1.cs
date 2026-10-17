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
           
            // Limpa os valores antigos
            PrgServidores.Value = 0;
            PrgMotorGrafico.Value = 0;

            // Simula o carregamento dos sistemas do jogo
            for (int i = 0; i <= 100; i++)
            {
                PrgServidores.Value = i; // Atualiza status dos servidores
                PrgMotorGrafico.Value = i; // Atualiza motor gráfico
                System.Threading.Thread.Sleep(10); // Pequena pausa para animação visual
            }

            MessageBox.Show("Sistemas simulados e sincronizados com sucesso!", "Painel Leonida");
        }

        private void BtnCarregarAssets_Click(object sender, EventArgs e)
        {
            // Cria e abre a nova janela do mapa por cima da principal
            using (FrmLeonida telaMapa = new FrmLeonida())
            {
                telaMapa.ShowDialog(); // Abre como uma janela bloqueante (foca nela)
            }
        }
    }
}
