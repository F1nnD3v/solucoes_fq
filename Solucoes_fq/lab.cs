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
    public partial class lab : Form
    {
        public lab()
        {
            InitializeComponent();
        }

        private void barAddSoluto_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.OldValue > e.NewValue)
            {
                btnSolucao.Height--;
            }
            else
            {
                if(btnSolucao.Height > 10)
                {
                    btnSolucao.Height++;
                }
            }
        }
    }
}
