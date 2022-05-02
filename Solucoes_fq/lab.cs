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
        int solucao, soluto;
        float massaMolar = 0;
        public lab()
        {
            InitializeComponent();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(solucao < 2000)
            {
                solucao += 200;
                lblSolucao.Text = "Quantidade de solução: " + solucao + "ml";
                CalcularConcentracao(massaMolar, soluto, solucao);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(solucao > 200)
            {
                solucao -= 200;
                lblSolucao.Text = "Quantidade de solução: " + solucao + "ml";
                if(CalcularConcentracao(massaMolar, soluto, solucao))
                {

                }
            }
        }

        private void btnAddSoluto_Click(object sender, EventArgs e)
        {
            if(soluto < 1000)
            {
                soluto += 100;
                lblSoluto.Text = "Quantidade de soluto: " + soluto + " moles";
            }
        }

        private void cboxSolucoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            soluto = 0;
            switch (cboxSolucoes.Text)
            {
                case "Cloreto de cobalto":
                    BackColor = Color.PaleVioletRed;
                    break;
                case "Nitrato de cobalto":
                    BackColor = Color.Red;
                    break;
                case "Cloreto de níquel":
                    BackColor = Color.Green;
                    break;
                case "Sulfato de cobre":
                    BackColor = Color.Blue;
                    break;
            }
        }

        private void btnRemoveSoluto_Click(object sender, EventArgs e)
        {
            if(soluto > 0)
            {
                soluto -= 100;
                lblSoluto.Text = "Quantidade de soluto: " + soluto + " moles";
            }
        }

        private void lab_Load(object sender, EventArgs e)
        {
            solucao = 200;
            soluto = 0;
            lblSolucao.Text = "Quantidade de solução: " + solucao + "ml";
            lblSoluto.Text = "Quantidade de soluto: " + soluto + " moles";
            String[] solu = { "Nitrato de cobalto", "Cloreto de cobalto", "Cloreto de níquel", "Sulfato de cobre"};
            for(int i = 0; i < solu.Length; i++)
            {
                cboxSolucoes.Items.Add(solu[i]);
            }
        }

        public float CalcularConcentracao(float massaMolar, int quantSoluto, int quantSolucao)
        {
            float concentracao = 0;
            concentracao = quantSoluto / (massaMolar * quantSolucao);
            return concentracao;
        }
    }
}
