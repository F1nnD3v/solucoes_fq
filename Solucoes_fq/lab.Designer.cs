
namespace Solucoes_fq
{
    partial class lab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddSolucao = new System.Windows.Forms.Button();
            this.btnRemoveSolucao = new System.Windows.Forms.Button();
            this.lblSolucao = new System.Windows.Forms.Label();
            this.cboxSolucoes = new System.Windows.Forms.ComboBox();
            this.lblSoluto = new System.Windows.Forms.Label();
            this.btnRemoveSoluto = new System.Windows.Forms.Button();
            this.btnAddSoluto = new System.Windows.Forms.Button();
            this.lblSaturado = new System.Windows.Forms.Label();
            this.lblSaturacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSolucao
            // 
            this.btnAddSolucao.Location = new System.Drawing.Point(33, 207);
            this.btnAddSolucao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSolucao.Name = "btnAddSolucao";
            this.btnAddSolucao.Size = new System.Drawing.Size(56, 19);
            this.btnAddSolucao.TabIndex = 4;
            this.btnAddSolucao.Text = "+";
            this.btnAddSolucao.UseVisualStyleBackColor = true;
            this.btnAddSolucao.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveSolucao
            // 
            this.btnRemoveSolucao.Location = new System.Drawing.Point(33, 231);
            this.btnRemoveSolucao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveSolucao.Name = "btnRemoveSolucao";
            this.btnRemoveSolucao.Size = new System.Drawing.Size(56, 19);
            this.btnRemoveSolucao.TabIndex = 5;
            this.btnRemoveSolucao.Text = "-";
            this.btnRemoveSolucao.UseVisualStyleBackColor = true;
            this.btnRemoveSolucao.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSolucao
            // 
            this.lblSolucao.AutoSize = true;
            this.lblSolucao.Location = new System.Drawing.Point(175, 210);
            this.lblSolucao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolucao.Name = "lblSolucao";
            this.lblSolucao.Size = new System.Drawing.Size(151, 13);
            this.lblSolucao.TabIndex = 6;
            this.lblSolucao.Text = "Quantidade de solução: 200ml";
            // 
            // cboxSolucoes
            // 
            this.cboxSolucoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSolucoes.FormattingEnabled = true;
            this.cboxSolucoes.Location = new System.Drawing.Point(333, 205);
            this.cboxSolucoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxSolucoes.Name = "cboxSolucoes";
            this.cboxSolucoes.Size = new System.Drawing.Size(92, 21);
            this.cboxSolucoes.TabIndex = 7;
            this.cboxSolucoes.SelectedIndexChanged += new System.EventHandler(this.cboxSolucoes_SelectedIndexChanged);
            // 
            // lblSoluto
            // 
            this.lblSoluto.AutoSize = true;
            this.lblSoluto.Location = new System.Drawing.Point(429, 210);
            this.lblSoluto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoluto.Name = "lblSoluto";
            this.lblSoluto.Size = new System.Drawing.Size(142, 13);
            this.lblSoluto.TabIndex = 8;
            this.lblSoluto.Text = "Quantidade de soluto: 200ml";
            // 
            // btnRemoveSoluto
            // 
            this.btnRemoveSoluto.Location = new System.Drawing.Point(643, 232);
            this.btnRemoveSoluto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveSoluto.Name = "btnRemoveSoluto";
            this.btnRemoveSoluto.Size = new System.Drawing.Size(56, 19);
            this.btnRemoveSoluto.TabIndex = 10;
            this.btnRemoveSoluto.Text = "-";
            this.btnRemoveSoluto.UseVisualStyleBackColor = true;
            this.btnRemoveSoluto.Click += new System.EventHandler(this.btnRemoveSoluto_Click);
            // 
            // btnAddSoluto
            // 
            this.btnAddSoluto.Location = new System.Drawing.Point(643, 207);
            this.btnAddSoluto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSoluto.Name = "btnAddSoluto";
            this.btnAddSoluto.Size = new System.Drawing.Size(56, 19);
            this.btnAddSoluto.TabIndex = 9;
            this.btnAddSoluto.Text = "+";
            this.btnAddSoluto.UseVisualStyleBackColor = true;
            this.btnAddSoluto.Click += new System.EventHandler(this.btnAddSoluto_Click);
            // 
            // lblSaturado
            // 
            this.lblSaturado.AutoSize = true;
            this.lblSaturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturado.Location = new System.Drawing.Point(329, 78);
            this.lblSaturado.Name = "lblSaturado";
            this.lblSaturado.Size = new System.Drawing.Size(93, 24);
            this.lblSaturado.TabIndex = 11;
            this.lblSaturado.Text = "Saturado";
            // 
            // lblSaturacao
            // 
            this.lblSaturacao.AutoSize = true;
            this.lblSaturacao.Location = new System.Drawing.Point(242, 144);
            this.lblSaturacao.Name = "lblSaturacao";
            this.lblSaturacao.Size = new System.Drawing.Size(35, 13);
            this.lblSaturacao.TabIndex = 12;
            this.lblSaturacao.Text = "label1";
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaturacao);
            this.Controls.Add(this.lblSaturado);
            this.Controls.Add(this.btnRemoveSoluto);
            this.Controls.Add(this.btnAddSoluto);
            this.Controls.Add(this.lblSoluto);
            this.Controls.Add(this.cboxSolucoes);
            this.Controls.Add(this.lblSolucao);
            this.Controls.Add(this.btnRemoveSolucao);
            this.Controls.Add(this.btnAddSolucao);
            this.Name = "lab";
            this.Text = "lab";
            this.Load += new System.EventHandler(this.lab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddSolucao;
        private System.Windows.Forms.Button btnRemoveSolucao;
        private System.Windows.Forms.Label lblSolucao;
        private System.Windows.Forms.ComboBox cboxSolucoes;
        private System.Windows.Forms.Label lblSoluto;
        private System.Windows.Forms.Button btnRemoveSoluto;
        private System.Windows.Forms.Button btnAddSoluto;
        private System.Windows.Forms.Label lblSaturado;
        private System.Windows.Forms.Label lblSaturacao;
    }
}