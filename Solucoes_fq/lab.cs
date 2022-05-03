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
        double massaMolar = 0;
        public lab()
        {
            InitializeComponent();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(solucao < 2000)
            {
                
                solucao += 200;
                if(cboxSolucoes.Text != "")
                {
                    lblSaturacao.Text = "Saturação: " + CalcularConcentracao(massaMolar, soluto, solucao);
                }
                lblSolucao.Text = "Quantidade de solução: " + solucao + "ml";
                if(soluto > solucao)
                {
                    lblSaturado.Show();

                }
                else
                {
                    lblSaturado.Hide();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(solucao > 200)
            {
                solucao -= 200;
                if (cboxSolucoes.Text != "")
                {
                    lblSaturacao.Text = "Saturação: " + CalcularConcentracao(massaMolar, soluto, solucao);
                }
                lblSolucao.Text = "Quantidade de solução: " + solucao + "ml";
                if (soluto > solucao)
                {
                    lblSaturado.Show();
                }
                else
                {
                    lblSaturado.Hide();
                }
            }
        }

        private void btnAddSoluto_Click(object sender, EventArgs e)
        {
            if(soluto < 1000 && cboxSolucoes.Text != "")
            {
                soluto += 100;
                if (cboxSolucoes.Text != "")
                {
                    lblSaturacao.Text = "Saturação: " + CalcularConcentracao(massaMolar, soluto, solucao);
                }
                lblSoluto.Text = "Quantidade de soluto: " + soluto + " moles";
            }

            if (soluto > solucao)
            {
                lblSaturado.Show();
            }
            else
            {
                lblSaturado.Hide();
            }
        }

        private void cboxSolucoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            soluto = 0;
            switch (cboxSolucoes.Text)
            {
                case "Cloreto de cobalto":
                    BackColor = Color.PaleVioletRed;
                    massaMolar = 129.839;
                    break;
                case "Nitrato de cobalto":
                    BackColor = Color.Red;
                    massaMolar = 182.943;
                    break;
                case "Cloreto de níquel":
                    BackColor = Color.Green;
                    massaMolar = 129.5994;
                    break;
                case "Sulfato de cobre":
                    BackColor = Color.Blue;
                    massaMolar = 159.609;
                    break;
                case "Dicromato de Potássio":
                    BackColor = Color.Orange;
                    massaMolar = 294.185;
                    break;
                case "Permanganato de Potássio":
                    BackColor = Color.Purple;
                    massaMolar = 158.034;
                    break;
                default:
                    BackColor = Color.LightBlue;
                    massaMolar = 0;
                    break;
            }

            lblSaturacao.Text = "Saturação: 0";
            soluto = 0;
            lblSoluto.Text = "Quantidade de soluto: " + soluto + " moles";

            if (soluto > solucao)
            {
                lblSaturado.Show();
            }
            else
            {
                lblSaturado.Hide();
            }
        }

        private void btnRemoveSoluto_Click(object sender, EventArgs e)
        {
            if(soluto > 0 && cboxSolucoes.Text != "")
            {
                soluto -= 100;
                if (cboxSolucoes.Text != "")
                {
                    lblSaturacao.Text = "Saturação: " + CalcularConcentracao(massaMolar, soluto, solucao);
                }
                lblSoluto.Text = "Quantidade de soluto: " + soluto + " moles";
            }

            if (soluto > solucao)
            {
                lblSaturado.Show();
            }
            else
            {
                lblSaturado.Hide();
            }
        }

        private void lab_Load(object sender, EventArgs e)
        {
            lblSaturacao.Text = "Saturação: 0";
            lblSaturado.Hide();
            solucao = 200;
            soluto = 0;
            lblSolucao.Text = "Quantidade de solução: " + solucao + "ml";
            lblSoluto.Text = "Quantidade de soluto: " + soluto + " moles";
            String[] solu = { "Nitrato de cobalto", "Cloreto de cobalto", "Cloreto de níquel", "Sulfato de cobre"};
            for(int i = 0; i < solu.Length; i++)
            {
                cboxSolucoes.Items.Add(solu[i]);
            }

            if (soluto > solucao)
            {
                lblSaturado.Show();
            }
            else
            {
                lblSaturado.Hide();
            }
        }

        private void lab_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
            lab lab = new lab();
            lab.Close();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
            lab lab = new lab();
            lab.Close();
        }

        public double CalcularConcentracao(double massaMolar, int quantSoluto, int quantSolucao)
        {
            double concentracao = 0;
            concentracao = quantSoluto / (massaMolar * quantSolucao);
            return concentracao;
        }
    }
}
