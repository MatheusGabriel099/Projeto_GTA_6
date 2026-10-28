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
    public partial class Frm_Trailer : Form
    {
        public Frm_Trailer()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = @"Video/Trailer2.mp4";
        }

        private void Frm_Trailer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
