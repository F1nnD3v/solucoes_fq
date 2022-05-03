using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucoes_fq
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnComeçar_Click(object sender, EventArgs e)
        {
            this.Hide();

            lab lab = new lab();
            lab.Show();
        }

        private void btnFormula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A fórmula para saber a concentração é:\nM = m/MM * V \nou \nM = n/V\nM = concentração molar\nm = massa(g)\nMM = massa molar\nV = volume(L)\nn = número de mol");
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
