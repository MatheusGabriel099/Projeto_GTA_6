using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGTA6
{
    public partial class FrmLeonida : Form
    {
        public FrmLeonida()
        {
            InitializeComponent();
        }

        private void FrmLeonida_Load(object sender, EventArgs e)
        {
         
        }

        private void CboDistritos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RdbViceCity_CheckedChanged(object sender, EventArgs e)
        {
            // Colocando a Imagem quando Clicar no Botão
            PicMapa.Image = Properties.Resources.Vice_City2; 

            // Coloca os Dados na TextBox
            TxtDetalhesDistrito.Text = "VICE CITY:\r\n- Status: Monitorado\r\n- Tráfego: Crítico\r\n- Iluminação: Neon Ativo.";
        }

        private void RdbLeonidaRural_CheckedChanged(object sender, EventArgs e)
        {
            // Colocando a Imagem quando Clicar no Botão
            PicMapa.Image = Properties.Resources.pantano; 

            // Coloca os Dados na TextBox
            TxtDetalhesDistrito.Text = "LEONIDA RURAL:\r\n- Status: Alerta\r\n- Fauna: Ativa (Jacarés)\r\n- Sinal de Rede: Instável.";
        }

        private void RdbViceBeaches_CheckedChanged(object sender, EventArgs e)
        {
            // Colocando a Imagem quando Clicar no Botão
            PicMapa.Image = Properties.Resources.praia; 

            // Coloca os Dados na TextBox
            TxtDetalhesDistrito.Text = "VICE BEACHES:\r\n- Status: Sincronizado\r\n- Zona: Litoral e Turismo\r\n- Policiamento: Elevado.";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha a tela Mapas e volta para a Tela Principal
            this.Close(); 
        }
    }
}
