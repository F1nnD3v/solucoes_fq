
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
            this.SuspendLayout();
            // 
            // btnAddSolucao
            // 
            this.btnAddSolucao.Location = new System.Drawing.Point(188, 256);
            this.btnAddSolucao.Name = "btnAddSolucao";
            this.btnAddSolucao.Size = new System.Drawing.Size(75, 23);
            this.btnAddSolucao.TabIndex = 4;
            this.btnAddSolucao.Text = "+";
            this.btnAddSolucao.UseVisualStyleBackColor = true;
            this.btnAddSolucao.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveSolucao
            // 
            this.btnRemoveSolucao.Location = new System.Drawing.Point(188, 286);
            this.btnRemoveSolucao.Name = "btnRemoveSolucao";
            this.btnRemoveSolucao.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSolucao.TabIndex = 5;
            this.btnRemoveSolucao.Text = "-";
            this.btnRemoveSolucao.UseVisualStyleBackColor = true;
            this.btnRemoveSolucao.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSolucao
            // 
            this.lblSolucao.AutoSize = true;
            this.lblSolucao.Location = new System.Drawing.Point(290, 262);
            this.lblSolucao.Name = "lblSolucao";
            this.lblSolucao.Size = new System.Drawing.Size(188, 16);
            this.lblSolucao.TabIndex = 6;
            this.lblSolucao.Text = "Quantidade de solução: 200ml";
            // 
            // cboxSolucoes
            // 
            this.cboxSolucoes.FormattingEnabled = true;
            this.cboxSolucoes.Location = new System.Drawing.Point(489, 256);
            this.cboxSolucoes.Name = "cboxSolucoes";
            this.cboxSolucoes.Size = new System.Drawing.Size(121, 24);
            this.cboxSolucoes.TabIndex = 7;
            this.cboxSolucoes.SelectedIndexChanged += new System.EventHandler(this.cboxSolucoes_SelectedIndexChanged);
            // 
            // lblSoluto
            // 
            this.lblSoluto.AutoSize = true;
            this.lblSoluto.Location = new System.Drawing.Point(629, 262);
            this.lblSoluto.Name = "lblSoluto";
            this.lblSoluto.Size = new System.Drawing.Size(176, 16);
            this.lblSoluto.TabIndex = 8;
            this.lblSoluto.Text = "Quantidade de soluto: 200ml";
            // 
            // btnRemoveSoluto
            // 
            this.btnRemoveSoluto.Location = new System.Drawing.Point(811, 285);
            this.btnRemoveSoluto.Name = "btnRemoveSoluto";
            this.btnRemoveSoluto.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSoluto.TabIndex = 10;
            this.btnRemoveSoluto.Text = "-";
            this.btnRemoveSoluto.UseVisualStyleBackColor = true;
            this.btnRemoveSoluto.Click += new System.EventHandler(this.btnRemoveSoluto_Click);
            // 
            // btnAddSoluto
            // 
            this.btnAddSoluto.Location = new System.Drawing.Point(811, 255);
            this.btnAddSoluto.Name = "btnAddSoluto";
            this.btnAddSoluto.Size = new System.Drawing.Size(75, 23);
            this.btnAddSoluto.TabIndex = 9;
            this.btnAddSoluto.Text = "+";
            this.btnAddSoluto.UseVisualStyleBackColor = true;
            this.btnAddSoluto.Click += new System.EventHandler(this.btnAddSoluto_Click);
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveSoluto);
            this.Controls.Add(this.btnAddSoluto);
            this.Controls.Add(this.lblSoluto);
            this.Controls.Add(this.cboxSolucoes);
            this.Controls.Add(this.lblSolucao);
            this.Controls.Add(this.btnRemoveSolucao);
            this.Controls.Add(this.btnAddSolucao);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}